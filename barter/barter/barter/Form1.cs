using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FirebirdSql.Data.FirebirdClient;

namespace barter
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        //public string myConnectionString = "Database=D:/proekt/barter/bd/BARTER.FDB;User=SYSDBA;Password=masterkey;Dialect=3;Server=127.0.0.1";
        public string myConnectionString = "Database=c:/barter/bd/BARTER.FDB;User=SYSDBA;Password=masterkey;Dialect=3;Server=127.0.0.1";
        private string sqlzapros, prn;
        private FbConnection myConn;
        private FbTransaction myTxn;
        private FbCommand command;
        private FbDataReader reader;
        private FbDataAdapter da;
        public DataSet ds;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this);
        }
        
        
        private void insert(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void print()
        {
            myConn = new FbConnection(myConnectionString);
            myConn.Open();
            myTxn = myConn.BeginTransaction();
            command = new FbCommand("SELECT * FROM bart "+"where id="+prn, myConn, myTxn);


            reader = command.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    MessageBox.Show("Этаж - " + reader.GetValue(5) + "\n" + "Хозяев - " + reader.GetValue(7) + "\n" +
                                   "Мат_дом - " + reader.GetValue(8) + "\n" + "Балкон - " + reader.GetValue(9) + "\n" +
                                   "Телефон - " + reader.GetValue(10) + "\n" + "Кол_собств. - " + reader.GetValue(11) + "\n" +
                                   "План_комн - " + reader.GetValue(12) + "\n" + "Санузел - " + reader.GetValue(13) + "\n" +
                                    "Кон_тел - " + reader.GetValue(14));                     
                }
            }
            finally
            {
                reader.Close();
                myTxn.Commit();
                myConn.Close();
            }

        }

        private void del()
        {
            myConn = new FbConnection(myConnectionString);
            myConn.Open();
            da = new FbDataAdapter();
            myTxn = myConn.BeginTransaction();
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        da.DeleteCommand = new FbCommand("delete from bart where id=@id", myConn, myTxn);
                        da.DeleteCommand.Parameters.Add("@id", ds.Tables[0].Rows[i][5].ToString());
                        da.DeleteCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("строка не должна быть пустой");
                    }

                }

            }
            myTxn.Commit();
            myConn.Close();

            
        }

        private void data_print()
        {
            Column1.Visible = false;
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[6].Visible = false;
            ds.Tables[0].Columns[4].ColumnName = "Дата";
            ds.Tables[0].Columns[3].ColumnName = "Квартира";
            ds.Tables[0].Columns[2].ColumnName = "Адрес";
            ds.Tables[0].Columns[1].ColumnName = "Площаль";
            ds.Tables[0].Columns[0].ColumnName = "Цена";
            myTxn.Commit();
            myConn.Close();

        }

        private void download()
        {
            myConn = new FbConnection(myConnectionString);
            myConn.Open();
            da = new FbDataAdapter();
            myTxn = myConn.BeginTransaction();
            da.SelectCommand = new FbCommand(sqlzapros, myConn, myTxn);
            data_print();
        }

        private void find()
        {
            myConn = new FbConnection(myConnectionString);
            myConn.Open();
            da = new FbDataAdapter();
            myTxn = myConn.BeginTransaction();
            da.SelectCommand = new FbCommand(sqlzapros, myConn, myTxn);
            da.SelectCommand.Parameters.Add("@adress", "%" + textBox1.Text + "%");
            da.SelectCommand.Parameters.Add("@ploshad", "%" + textBox1.Text + "%");
            da.SelectCommand.Parameters.Add("@cena", "%" + textBox1.Text + "%");
            data_print();
           
        }

        private void find2()
        {
            
            myConn = new FbConnection(myConnectionString);
            myConn.Open();
            da = new FbDataAdapter();
            myTxn = myConn.BeginTransaction();
            da.SelectCommand = new FbCommand(sqlzapros, myConn, myTxn);
            da.SelectCommand.Parameters.Add("@kv", textBox2.Text);
            data_print();
           
        }


        private void form1_find(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void form1_edit_find(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ControlChars.Cr)
            {
                sqlzapros = "SELECT cena,ploshad,adress,kv,date1,id FROM bart where adress like @adress or ploshad like @ploshad or cena like @cena";
                find();
            }
        }

        private void form1_edit_find2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ControlChars.Cr)
            {
                sqlzapros = "SELECT cena,ploshad,adress,kv,date1,id FROM bart where kv=@kv";
                find2();
            }

        }

        private void form1_menu_all(object sender, EventArgs e)
        {
            sqlzapros = "SELECT cena,ploshad,adress,kv,date1,id FROM bart";
            download();
        }

        private void menu_del(object sender, EventArgs e)
        {
            del();
          
        }

        private void form1_grid_ex(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        prn = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        print();
                        
                    }
                    else
                    {
                        MessageBox.Show("строка не должна быть пустой");
                    } 

                }

            }
        }

        private void menu_form1_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_form1_variant(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

           

        
    }
}
