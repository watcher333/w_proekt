using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace restore_base
{
    class Program
    {
       

        static void Main(string[] args)
        {
            SqlConnection connection;
            SqlCommand command;

           string  connectionString = "server=" + "192.168.0.2" + ";uid=sa" + ";pwd=aksW9Sjv7ub4Z";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                DataTable schemaTable = connection.GetSchema("Databases");


                foreach (DataRow row in schemaTable.Rows)
                {
                    Console.WriteLine(row[0]);
                    
                }

               /* command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "RESTORE DATABASE test2 FROM  DISK = '"+@"\\192.168.0.2\e$\temp\test1.bak"+"' WITH  FILE = 1,  MOVE 'test1' TO '"+@"E:\temp\test2\test2.mdf"+"',MOVE 'test1_log' TO '"+@"E:\temp\test2\test2_log.ldf"+"',  KEEP_REPLICATION,  NOUNLOAD,  REPLACE,  STATS = 10";
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                connection.Close();*/
               


               

            }
            catch (SqlException e)
            {
               Console.WriteLine(e.Message.ToString());

            }
            Console.ReadLine();
        }
    }
}
