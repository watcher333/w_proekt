using System;
using System.Net.Mail;


namespace shrink_
{

	class mail
   {
		public void smtp(String report)
		{
		
			string server = "mail.fondgkh-nso.ru";
			string msg_from = "svv@fondgkh-nso.ru";
			string smtp_login = "svv@fondgkh-nso.ru";
            string smtp_pass = "ag7ce12Xqz15";
           	string msg_to = "svv@fondgkh-nso.ru";
            string msg_subj = "shrink#";


                MailMessage message = new MailMessage(msg_from, msg_to, msg_subj, report);
                SmtpClient client = new SmtpClient(server, 25);
                client.Credentials = new System.Net.NetworkCredential(smtp_login, smtp_pass);
                try
                {
                    client.Send(message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }

            }

		}
		
		
	}
