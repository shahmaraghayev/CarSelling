using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using CarSellingDAL.Domain;
using CarSellingDAL;
using Microsoft.Extensions.Logging;
using NLog;

namespace CarSelling.Utils
{

  public  class EmailSending
    {
        Logger logger;

        public EmailSending()
        {
            logger = LogManager.GetCurrentClassLogger();

        }
        private void  SaveCodeToDB(string email, int kod, DateTime kodGenerateDate)
        {
            try
            {
                EmailChacingDal e = new EmailChacingDal();
                EmailChecking k = new EmailChecking();
                k.Email = email;
                k.Kod = kod;
                k.KodGenerateDate = kodGenerateDate;
                e.Insert(k);
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Insert Department");
                throw;
            }
            
        }     

        public string RandomGenerator()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999).ToString("D6");
            return r;
        }
        //private void btnbrowse_Click(object sender, EventArgs e)
        //{
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        txtattachment.Text = openFileDialog1.FileName.ToString();
        //    }

        //}
        public void SendCode(string reciver)
        {
            string email = "testingapplication93@gmail.com";
            string password = "0702252723@@";
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//works if you have a gmail account
                MailMessage message = new MailMessage();//creating a new email object
                message.From = new MailAddress(email);//your email id 
                message.To.Add(reciver);//Recievers email 

                string randon= RandomGenerator();
                message.Body = randon;//Body of the email
                
                message.Subject ="Sifre yoxlama" ;//Subject of the email
                client.UseDefaultCredentials = false; //Ovveriding default credentials 
                client.EnableSsl = true;//enabling ssl security
               
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential(email, password);//giving your login credentials
                client.Send(message);// sending email
                message = null;//freesing hte memory  you of the message

                SaveCodeToDB(reciver,Convert.ToInt32(randon),DateTime.Now);
            }
            catch (Exception exp)
            {
                logger.Error(exp, "SendCode");
                throw;
            }

        }
    }
}
