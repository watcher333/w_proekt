using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace reg_program
{
    class ex:translit
    {
        MySqlConnection con;
        MySqlCommand cmd,cmd2;
        MySqlDataReader rdr;
        string[] name;
        string[] str;
        string gorod, street, dom, trans_str;
        string sql,sql2;
        int j;
        public void conn()
        {
            string connStr = "server=192.168.10.8;user=rootw;database=336J7;port=3306;password=12qwER!@;charset=utf8;";
            con = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                con.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
           //Console.WriteLine("Done.");

        }

        public void report()
        {
            name = Directory.GetFiles(@"c:\ex\1_1\");
            j = 0;
            
            try
            {

                sql = "SELECT gorod , adress ,dom, url_file FROM pp983_report_dom;";
                
                

                for (int i = 0; i < name.Length; i++)
                {
                    conn();
                    cmd = new MySqlCommand(sql, con);
                    rdr = cmd.ExecuteReader();

                    
                    //Console.WriteLine(Path.GetFileName(name[i]));
                    str = Path.GetFileNameWithoutExtension(name[i]).Split(',');
                   
                    gorod = str[0];
                    //gorod = str[0] + " " + "г";И
                    //street = str[1] + " " + "ул";
                    street = str[1];
                    dom = str[2];
                    trans_str = "*Отчет за третий квартал 2018 Форма4*" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_III_2018.xlsx";         //add
                    //trans_str = "Отчет за третий квартал 2018 Форма1*" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_III_2018.xlsx";   //new
                    //trans_str = "*Акт приемочной комиссии за 2 кв 2017*" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_II_2017.pdf"; //akty_pdf

                    Console.WriteLine(gorod+"\n"+street+"\n"+dom+"\n");

                   while (rdr.Read())
                    {
                        //Console.WriteLine(rdr[0].ToString() + " " + gorod + " " + rdr[1].ToString() + " " + street + " " + rdr[2].ToString() + " " + dom);
                        if(rdr[0].ToString()==gorod && rdr[1].ToString()==street && rdr[2].ToString()==dom)
                        {
                            sql2 = "update pp983_report_dom set url_file='" + rdr[3].ToString() +trans_str + "' where gorod='" + gorod + "' && adress='" + street + "' && dom='" + dom + "';";
                            //sql2 = "update pp983_report_dom set url_file='1111'"+ " where gorod='" + gorod + "' && adress='" + street + "' && dom='" + dom + "';";
                            //byte[] bytes = Encoding.Default.GetBytes(sql2);
                            //sql2 = Encoding.UTF8.GetString(bytes);
                            conn();
                            cmd2 = new MySqlCommand(sql2, con);
                            cmd2.ExecuteNonQuery();
                            File.Move(Path.GetFullPath(name[i]), @"c:\ex\1_1\" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_III_2018.xlsx");
                            //File.Move(Path.GetFullPath(name[i]), @"c:\ex\1_1\" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_II_2017.pdf");
                            Console.WriteLine(sql2);
                            j++;
                            break;
                        }
                        //Console.WriteLine(rdr[0] + " -- " + rdr[1] + "---" + rdr[2]);
                        
                        
                    }
                    rdr.Close();

                  /* sql = "INSERT INTO pp983_report_dom (gorod,adress,dom,url_file) VALUES ('" + gorod + "','" + street + "','" + dom + "','" + trans_str + "');";
                    Console.WriteLine(sql);
                    conn();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    File.Move(Path.GetFullPath(name[i]), @"c:\ex\1_1\" + trans(Path.GetFileNameWithoutExtension(name[i])) + "_II_2017.xlsx");*/
                    
                }
                Console.WriteLine("Chislo_vhodov="+j);
                
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        con.Close();

        }
    }
}
