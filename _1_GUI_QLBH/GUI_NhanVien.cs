using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1_GUI_QLBH
{
    public class GUI_NhanVien
    {
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        //Tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string maxacnhan)
        {
            try
            {
                //Now we must create a new Smtp client to send our email.
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //smtp.gmail.com // For Gmail //Authentication.
                                                                           //This is where the valid email account comes into play. You must have a valid email //account (with password) to give our program a place to send the mail from.
                NetworkCredential cred = new NetworkCredential("baotncps40789@gmail.com", "jflb jhdg dqht lwra");
                //To send an email we must first create a new mailMessage (an email) to send. 
                MailMessage Msg = new MailMessage();
                // Sender e-mail address.
                Msg.From = new MailAddress("baotncps40789@gmail.com"); //Nothing But Above Credentials or your credentials (*******@gmail.com) // Recipient e-mail address.
                Msg.To.Add(email);
                // Assign the subject of our message.
                Msg.Subject = "Anh/chị đã sử dụng tính năng quên mật khẩu";
                // Create the content (body) of our message.
                Msg.Body = "Chào anh/chị. Mã xác nhận là: " + maxacnhan;
                // Send our account login details to the client.
                client.Credentials = cred;
                //Enabling SSL (Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;
                client.Send(Msg); // Send our email.
            }
            catch (Exception)
            {
            }
        }
    }
    
}
        
        

