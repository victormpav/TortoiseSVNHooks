using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ReviewHook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace HookReviewUi
{
    public partial class ReviewCreationDlg : Form
    {
        private string m_reviewPatchFilePath;
        private string m_workingCopyPath;
        private string m_commitMessageFilePath;

        public ReviewCreationDlg(string workingCopyPath, string commitMessageFilePath, string reviewPatchFile)
        {
            m_workingCopyPath = workingCopyPath;
            m_reviewPatchFilePath = reviewPatchFile;
            m_commitMessageFilePath = commitMessageFilePath;

            InitializeComponent();

            SvnCommands svnCommands = new SvnCommands();
            reviewDescriptionTextBox.Text = svnCommands.GetCommitMessageTemplate(m_workingCopyPath);
            GroupTextBox.Text = Settings.Default.reviewerEmail;
        }

        private void sendReviewButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(m_commitMessageFilePath, reviewDescriptionTextBox.Text);

            try
            {
                Outlook.Application oApp = new Outlook.Application();
                
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                oMsg.Body = reviewDescriptionTextBox.Text;

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
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(GroupTextBox.Text);
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

            Settings.Default.reviewerEmail = GroupTextBox.Text;
            Settings.Default.Save();

            string strCmdText;
            strCmdText = @"post --branch ""{0}"" --target-groups ""{1}"" --markdown --description- file ""{2}""";
            string branch = "trunk";
            string group = "ips";
            
            Process process = new Process();
            process.StartInfo.FileName = "rbt";
            process.StartInfo.WorkingDirectory = m_workingCopyPath;
            process.StartInfo.Arguments = string.Format(strCmdText, branch, group, m_commitMessageFilePath);
            process.Start();
            process.WaitForExit();
            
            Close();
        }
    }
}
