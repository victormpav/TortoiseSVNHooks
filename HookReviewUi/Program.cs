using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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

                List<string> pathsToBinaryFilesInPatch = patchGenerator.PatchToBinaryFiles(patchPath);

                File.Delete(Path.Combine(workingCopyPath, "binaryFiles.zip"));

                if (pathsToBinaryFilesInPatch.Count > 0)
                {
                    using (
                        ZipArchive zipFile = ZipFile.Open(Path.Combine(workingCopyPath, "binaryFiles.zip"), ZipArchiveMode.Create))
                    {
                        foreach (string pathToBinaryFilesInPatch in pathsToBinaryFilesInPatch)
                        {
                            if (File.Exists(pathToBinaryFilesInPatch))
                            {
                                zipFile.CreateEntryFromFile(Path.Combine(workingCopyPath, pathToBinaryFilesInPatch),
                                    pathToBinaryFilesInPatch);
                            }
                        }
                    }
                }

                Application.Run(new ReviewCreationDlg(workingCopyPath, commitMessage, patchPath));
            }

            return 0;
        }
    }
}
