using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Review
{
    

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   Outlook.MailItem mail = Application.CreateItem(
        Outlook.OlItemType.olMailItem) as Outlook.MailItem;
            mail.Subject = "Quarterly Sales Report FY06 Q4";
            Outlook.AddressEntry currentUser =
                Application.Session.CurrentUser.AddressEntry;
            if (currentUser.Type == "EX")
            {
                Outlook.ExchangeUser manager =
                    currentUser.GetExchangeUser().GetExchangeUserManager();
                // Add recipient using display name, alias, or smtp address
                mail.Recipients.Add(manager.PrimarySmtpAddress);
                mail.Recipients.ResolveAll();
                mail.Attachments.Add(@"c:\sales reports\fy06q4.xlsx",
                    Outlook.OlAttachmentType.olByValue, Type.Missing,
                    Type.Missing);
                mail.Send();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
