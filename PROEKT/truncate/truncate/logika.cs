using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truncate
{
    class logika:sql_command
    {
        public void start()
        {
            int i = 0;
            string sqlzapros;
            ArrayList tmp_log;

            connect();
           
            exec_sql("select name from	sys.databases where	name not in ('master','tempdb','model','msdb','ReportServer','ReportServerTempDB') 	and is_distributor = 0 	and isnull(source_database_id,0) = 0",0);
            
            for (i = 0; i < sql_base.Count; i++)
            {
               // Console.WriteLine(sql_base[i]);
                exec_sql("Use " + sql_base[i].ToString() + ";exec sp_helpfile;", 1);
                //Console.WriteLine("Use " + sql_base[i].ToString() + ";exec sp_helpfile;");
                
            }

            tmp_log = new ArrayList();
            tmp_log.AddRange(sql_base_log);
            sql_base_log.Clear();
            for (i = 1; i < tmp_log.Count; i=i+2)
            {
                sql_base_log.Add(tmp_log[i]);
                //Console.WriteLine(tmp_log[i]);
            }

            tmp_log.Clear();
            
           
           
            for (i = 0; i < sql_base_log.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sql_base[i]+"\n"+sql_base_log[i]);
                //sqlzapros = "use " + sql_base[i] + ";BACKUP LOG " + sql_base[i] + " WITH TRUNCATE_ONLY;DBCC SHRINKFILE(" + sql_base_log[i] + ");";
                sqlzapros = "use " + sql_base[i] + ";ALTER DATABASE " + sql_base[i] + " SET RECOVERY SIMPLE WITH NO_WAIT;" + "DBCC SHRINKFILE(" + sql_base_log[i] + ",1);"
                         	+ "ALTER DATABASE " + sql_base[i] + " SET RECOVERY FULL WITH NO_WAIT;"+"DBCC SHRINKDATABASE (" + sql_base[i] + ", 10)";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sqlzapros);
                truncate_log(sqlzapros);

            }
            Console.ResetColor();
            sql_base.Clear();
            sql_base_log.Clear();
            close();
        }

    }

   

   
}
