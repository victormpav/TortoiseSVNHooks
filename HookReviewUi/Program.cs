using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            DialogResult result = MessageBox.Show("Create Review", "Would you like to create a review?",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (args.Length < 3)
                {
                    Console.Error.WriteLine(String.Format("Wrong parameter list, expected 3 and receive {0}", args.Length));
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

              //  commitMessage = string.Format("{0} ***** {1} ***** {2}", args[0], args[1], args[2]);



                Application.Run(new ReviewCreationDlg(workingCopyPath, commitMessage, patchPath));
            }

            return 0;
        }
    }
}
