using System;
using System.IO;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace HookReviewUi
{
    public partial class ReviewCreationDlg : Form
    {
        private string m_reviewPatchFilePath;
        private string m_workingCopyPath;

        public ReviewCreationDlg(string workingCopyPath, string commitMessage, string reviewPatchFile)
        {
            m_workingCopyPath = workingCopyPath;
            m_reviewPatchFilePath = reviewPatchFile;
            InitializeComponent();
        }

        private void sendReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Application oApp = new Outlook.Application();
                
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                oMsg.Body = reviewMessageTextBox.Text;

                String sDisplayName = "Patch to review";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                
                Outlook.Attachment oAttach = oMsg.Attachments.Add(m_reviewPatchFilePath, iAttachType, iPosition, sDisplayName);

                if (System.IO.File.Exists(Path.Combine(m_workingCopyPath, "binaryFiles.zip")))
                {
                    String sDisplayName2 = "Binary files";
                    int iPosition2 = (int)oMsg.Body.Length + 2;
                    int iAttachType2 = (int)Outlook.OlAttachmentType.olByValue;

                    Outlook.Attachment oAttach2 = oMsg.Attachments.Add(Path.Combine(m_workingCopyPath, "binaryFiles.zip"), iAttachType2, iPosition2, sDisplayName2);
                }

                oMsg.Subject = "[CodeReview] - ";

                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(reviewerEmailTextBox.Text);
                oRecip.Resolve();
                
                oMsg.Send();

                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }
            catch (Exception ex)
            {
            }

            Close();
        }
    }
}
