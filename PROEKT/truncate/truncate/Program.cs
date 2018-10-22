
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace truncate
{
	class Program
	{
		public static void Main(string[] args)
		{
			logika logika = new logika();
            logika.start();
            Console.WriteLine("Зокроеться через 10 сек");
            Thread.Sleep(10000);

		}
	}
}