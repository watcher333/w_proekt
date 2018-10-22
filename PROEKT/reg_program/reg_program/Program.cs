using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace reg_program
{
    
    class Program
    {

        static void Main(string[] args)
        {
            ex ex = new ex();
            ex.report();
           
            Console.ReadLine();
        }
    }
}
