using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using ICSharpCode.SharpZipLib.Zip;
using System.Threading;
using System.Windows.Threading;

namespace restorebase
{
    class list_combo
    {
        public ComboBox srv_combo,to_combo,from_combo,date_combo;
        ListBox log_list;
        ProgressBar progress;
        public ArrayList path_base_zip;
        SqlConnection connection;
        DataTable schemaTable;
        String connectionString;
        FastZip fZip;
        Thread thread_unzip, thread_unzip_prv;

        public list_combo(ComboBox srv_combo, ComboBox to_combo, ComboBox from_combo, ComboBox date_combo, ListBox log_list, ProgressBar progress)
        {
            this.srv_combo = srv_combo;
            this.to_combo = to_combo;
            this.from_combo = from_combo;
            this.date_combo = date_combo;
            this.log_list = log_list;
            this.progress = progress;
            list_srv_combo();

        }

        public list_combo()
        {

        }
        private void list_srv_combo()
        {
           /* SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();

            // Display the contents of the table.
            DisplayData(table);*/
            srv_combo.Items.Add("rossita-bd");
        }

        private void DisplayData(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                srv_combo.Items.Add(row["ServerName"]);
            }
        }

        private void connect()
        {
            connectionString = "server=" + srv_combo.SelectedItem.ToString() + ";uid=sa" + ";pwd=aksW9Sjv7ub4Z";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                

            }
            catch (SqlException e)
            {
                log_list.Items.Add(e.Message.ToString());
                
            }
         
        }

        public void list_base_combo()
        {

            connect();
            try
            {
                
                schemaTable = connection.GetSchema("Databases");
              

                foreach (DataRow row in schemaTable.Rows)
                {
                    to_combo.Items.Add(row[0]);
                    from_combo.Items.Add(row[0]);
                }
            }

            catch (SqlException e)
            {
                log_list.Items.Add("Данные по базам по этому серверу отсутствуют");
                log_list.Items.Add(e.Message.ToString());
            }

            
        }

        public void list_date_combo()
        {
          DirectoryInfo dir;
          FileInfo[] file;
          

          path_base_zip = new ArrayList();
          path_base_zip.Clear();

          try
          {
              dir = new DirectoryInfo(@"\\192.168.0.4\SQL_bases$\" + srv_combo.SelectedItem.ToString() + @"\" + from_combo.SelectedItem.ToString() + @"\");

             
                  file = dir.GetFiles();
                  foreach (FileInfo files in file)
                  {
                      path_base_zip.Add(@"\\192.168.0.4\SQL_bases$\" + srv_combo.SelectedItem.ToString() + @"\" + from_combo.SelectedItem.ToString() + @"\" + files.Name);
                      date_combo.Items.Add(files.LastAccessTime + " " + files.Name);

                  }

            
              
          }
          catch (Exception e)
          {
              log_list.Items.Add("Данных по базе нету");
              log_list.Items.Add(e.Message.ToString());

          }


        }

        private void unzip_potok(object o)
        {
            object[] om = (object[])o;
            ListBox log_list = (ListBox)om[1];
            log_list.Dispatcher.BeginInvoke(new ThreadStart(delegate { log_list.Items.Add("Процесс распоковки..."); }));
            Thread.Sleep(2000);
            fZip = new FastZip();
            fZip.ExtractZip((string)om[0], @"\\192.168.0.2\temp_base$", "");
            Thread.Sleep(2000);
            log_list.Dispatcher.BeginInvoke(new ThreadStart(delegate { log_list.Items.Add("Процесс рапоковки окончен"); }));
           
            
        }

        private void unzip_prv_potok(object o2)
        {
            object[] om = (object[])o2;
            ProgressBar progress = (ProgressBar)om[0];
            ListBox log_list = (ListBox)om[1];
            int i = 0;
   
            while (thread_unzip.IsAlive == true)
            {
                Thread.Sleep(1000);
               

                if(i>=100)
                {
                    progress.Dispatcher.BeginInvoke(new ThreadStart(delegate { progress.Value=0; }));
                    i = 0;
                }
                
                progress.Dispatcher.BeginInvoke(new ThreadStart(delegate { progress.Value += 5; }));
                i+=5;
            }
            progress.Dispatcher.BeginInvoke(new ThreadStart(delegate { progress.Value=0; }));
        
        }
        public void unzip()
        {
            object o = new object[] { path_base_zip[date_combo.SelectedIndex].ToString(),log_list };
            object o2 = new object[] { progress, log_list };
            
            thread_unzip = new Thread(new ParameterizedThreadStart(unzip_potok));
            thread_unzip.Start(o);
            
            Thread.Sleep(1000);
            thread_unzip_prv = new Thread(new ParameterizedThreadStart(unzip_prv_potok));
            thread_unzip_prv.Start(o2);
            Thread.Sleep(2000);
            
            
        }

        public void stop_potok()
        {
            thread_unzip.Abort();
            thread_unzip_prv.Abort();
        }


    }
}
