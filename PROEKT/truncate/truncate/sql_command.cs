using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace truncate
{
    class sql_command
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        protected ArrayList sql_base;
        protected ArrayList sql_base_log;
        

        protected void connect()
        {
            
            string connectionString = "server=" + @"FLS" + ";uid=sa" + ";pwd=sql";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                sql_base_log = new ArrayList();
                sql_base = new ArrayList();

             }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(20000);
            }

       }
      
        protected void exec_sql(string sqlzapros,int x)
        {
            
             command = new SqlCommand(sqlzapros, connection);
            
                reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        if (x == 0)
                        {
                            sql_base.Add(reader[0].ToString().Trim());
                        }

                        if (x == 1)
                        {
                            sql_base_log.Add(reader[0].ToString().Trim());
                        }
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(20000);
                }

        }



        protected void truncate_log(string sqlzapros)
        {
            try
            {
                command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = sqlzapros;
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
            	Console.WriteLine(e.Message);
                Thread.Sleep(20000);
            }

        }
        protected void close()
        {
            connection.Close();
        }
    }

   
}

