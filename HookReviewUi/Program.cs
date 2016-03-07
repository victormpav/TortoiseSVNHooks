using System;
using System.Windows.Forms;
using HookReviewUi.Properties;
using ReviewHook;

namespace HookReviewUi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result = MessageBox.Show(Resources.Program_Main_Create_Review, Resources.Program_Main_Would_you_like_to_create_a_review_, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (args.Length < 3)
                {
                    Console.Error.WriteLine("Wrong parameter list, expected 3 and receive {0}", args.Length);
                    return 1;
                }
                
                string commitMessage;
                string workingCopyPath;

                try
                {
                    workingCopyPath = args[2];
                    commitMessage = System.IO.File.ReadAllText(args[1]);
                }
                catch (Exception)
                {
                    Console.Error.WriteLine("Cannot read input information");
                    return 1;
                }

                TortoiseSvnPatchGenerator patchGenerator = new TortoiseSvnPatchGenerator();
                string patchPath = patchGenerator.GetPatchFromWorkingCopy(workingCopyPath);

                Application.Run(new ReviewCreationDlg(workingCopyPath, commitMessage, patchPath));
            }

            return 0;
        }
    }
}
