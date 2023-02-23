using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace Randomotp
{
    class Otp
    {


        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                RandomNumberGenerator generator = new RandomNumberGenerator();
                
                int num = random.Next();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("athira007p@gmail.com");
                mail.To.Add("vishnuramesh33222@gmail.com");
                mail.Priority = MailPriority.High;
                mail.Subject = "Test Email";
                int rand = generator.RandomNumber(5, 100);
                mail.Body = rand.ToString();
                SmtpServer.Port = 587;               
                Console.WriteLine($"your otp is {mail.Body}");
                Console.ReadKey();
                SmtpServer.Credentials = new System.Net.NetworkCredential("athira007p@gmail.com", "cuvemprujgfntbox"); 
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Email Send Succesfully");

        }
    }

    public class RandomNumberGenerator
    {
        
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



        

    }
}

      


        //{

    //        
    //       
    //}


    //
    //            //        NewOtp = IDString;
    //            //    }
    //            //    return NewOtp;

    //          
//}
