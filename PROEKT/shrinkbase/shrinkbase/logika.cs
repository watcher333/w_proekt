using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shrinkbase
{
    class logika:sql_command
    {
        public void start()
        {
            int i = 0;
            string sqlzapros;
            

            connect();
           
            exec_sql("select name from	sys.databases where	name not in ('master','tempdb','model','msdb','ReportServer','ReportServerTempDB') 	and is_distributor = 0 	and isnull(source_database_id,0) = 0");
            
           
            for (i = 0; i < sql_base.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sql_base[i]);

                sqlzapros = "use " +sql_base[i]+";DBCC SHRINKDATABASE (" + sql_base[i] + ", 10)";
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sqlzapros);
                shrinkbase(sqlzapros);

            }
            Console.ResetColor();
            sql_base.Clear();
            close();
        }

    }

   

   
}
