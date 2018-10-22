
using System;
using System.IO;



namespace shrink_
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] array1;
			string destion;
			int i=0;
			
			
			array1=Directory.GetFiles(@"c:\aaa\", "*.csv");
			scp scp = new scp();
			mail mail = new mail();
			
			scp.connect();
						
			for(i=0;i<array1.Length;i++)
			{
				if(File.GetCreationTime(array1[i]).ToString("d")==DateTime.Today.ToString("d"))
				{
					/*destion=Path.GetFileNameWithoutExtension(array1[i]);
					destion=@"c:\aaa1\"+destion.Remove(destion.LastIndexOf('#'))+".csv";
				
				    File.Copy(array1[i],destion,true);
				    scp.report=scp.report+"source - "+array1[i]+"\n"+"destination - "+destion+"\n";
				    scp.transfer(destion,"/root/");
				    Console.WriteLine(destion);*/
				    
				    destion=Path.GetFileNameWithoutExtension(array1[i]);
				    destion="/root/"+destion.Remove(destion.LastIndexOf('#'))+".csv";
				    scp.report=scp.report+"source - "+array1[i]+"\n"+"destination - "+destion+"\n";
				    scp.transfer(array1[i],destion);
				    Console.WriteLine(destion);
				
				    
				}
				
															
				
			}
			
			scp.close();
			mail.smtp(scp.report);
			Console.ReadLine();
		}
	}
}