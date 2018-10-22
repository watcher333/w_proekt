
using System;
using WinSCP;

namespace shrink_
{

	class scp:mail
   {
		public String report;
		SessionOptions sessionOptions;
		Session session;
		TransferOptions transferOptions;
		TransferOperationResult transferResult;
		
		public void connect()
		{
			try
			{
			 sessionOptions = new SessionOptions {
                Protocol = Protocol.Sftp,
                HostName = "192.168.1.17",
                UserName = "root",
                Password = "12qwER!@",
                SshHostKeyFingerprint = "ssh-rsa 2048 98:b0:6e:ac:f9:7f:a3:e2:a1:c0:eb:8a:00:85:79:0d"
            };
			 session = new Session();
             session.Open(sessionOptions);
             transferOptions = new TransferOptions();
             transferOptions.TransferMode = TransferMode.Binary;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message.ToString()+"\n");
				smtp("Exception1 - "+e.Message.ToString()+"\n");
				Environment.Exit(0);
				
			}
		   
		}
		
     public void transfer(String source, String destination)
     {
     	try
     	{
     	      transferResult = session.PutFiles(source, destination, false, transferOptions);
              transferResult.Check();
                
               
                foreach (TransferEventArgs trans in transferResult.Transfers)
                {
                    Console.WriteLine("Upload of {0} succeeded", trans.FileName);
                    report=report+"Upload of "+trans.FileName+" succeeded"+"\n\n";
                }
     	}
     	catch(Exception e)
			{
				Console.WriteLine(e.Message.ToString()+"\n");
				smtp("Exception2 - "+e.Message.ToString()+"\n"+"source - "+source+"\n"+"destination - "+destination);
								
			}
             
    	
     }
     
     public void close()
     {
     	session.Close();
     }
    
	}
	}
