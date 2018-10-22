using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_podgotovka
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] name = Directory.GetFiles(@"c:\ex\1_1\");
            string[] name2;
            string wr = @"m:\3.txt";
            StreamWriter sw = new StreamWriter(wr, false, System.Text.Encoding.Default);

             for (int i = 0; i < name.Length; i++)
             {
                 name2 = Path.GetFileNameWithoutExtension(name[i]).Split(',');
                 sw.WriteLine(name2[2]);
                 
                 //Console.WriteLine(name2[0]);
             }
             //Console.ReadLine();
             sw.Close();
        }
    }
}
