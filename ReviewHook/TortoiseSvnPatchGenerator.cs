using System.Diagnostics;

namespace ReviewHook
{
    public class TortoiseSvnPatchGenerator
    {
        /// <summary>
        /// Generate patch from working copy directory given as parameter
        /// </summary>
        /// <param name="workingCopyPath">Working copy path</param>
        /// <returns>Path to patch file generated</returns>
        public string GetPatchFromWorkingCopy(string workingCopyPath)
        {
            string strCmdText;
            strCmdText = @"/command:createpatch /path:""{0}"" /savepath:""{1}""  /noview";
            string outputPath = System.IO.Path.Combine(workingCopyPath, "review.patch");

            Process process = new Process();
            process.StartInfo.FileName = "TortoiseProc.exe";
            process.StartInfo.WorkingDirectory = workingCopyPath;
            process.StartInfo.Arguments = string.Format(strCmdText, workingCopyPath, outputPath);
            process.Start();
            process.WaitForExit();

            return outputPath;
        }
    }
}
