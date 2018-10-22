using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cons_send
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] date;
            string file_in;
            string file_out;
            TimeSpan interval = new TimeSpan(0, 0, 30);

            date = DateTime.Now.ToString().Split(' ');
            date = date[0].Split('.');

            file_in = @"D:\consultant\ADM\STS\";
            //file_out = @"D:\consultant\ADM\sts_" + date[0] + "_" + date[1] + "_" + date[2] + ".zip";
            file_out = Path.Combine(@"D:\consultant\ADM", "sts_" + date[0] + "_" + date[1] + "_" + date[2] + ".zip");
           
                FastZip fz = new FastZip();
               // fz.CreateZip(file_out, file_in, true, "");

                 using (Stream stream = File.Create(file_out))
                 {
                     fz.CreateZip(stream, file_in, false, null,null);
                     stream.Close();
                     
                 }



                //Thread.Sleep(interval);

                
                     MailAddress from = new MailAddress("svv@fondgkh-nso.ru", "FondGKH");
                     MailAddress to = new MailAddress("seridina@rambler.ru");
                     MailMessage m = new MailMessage(from, to);
                     m.Attachments.Add(new Attachment(@"D:\consultant\RECEIVE\CONS#110_411767.USR"));
                     m.Attachments.Add(new Attachment(@"D:\consultant\ADM\USERLOG.TXT"));
                     m.Attachments.Add(new Attachment(file_out));
                     m.Subject = "FondGKH";
                     m.Body = "<h2>Fail Consultant</h2>";
                     m.IsBodyHtml = true;
                     SmtpClient smtp = new SmtpClient("mail.fondgkh-nso.ru", 25);
                     smtp.Credentials = new NetworkCredential("svv@fondgkh-nso.ru", "ag7ce12Xqz15");
                     smtp.EnableSsl = true;
                     smtp.Send(m);
                     m.Dispose();

                 

                
                     //Thread.Sleep(interval);

                     File.Delete(file_out);
                 
                
                //Console.ReadLine();
            
        }
    }
}
