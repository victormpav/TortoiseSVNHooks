using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

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

        public List<String> PatchToBinaryFiles(string patchPath)
        {
            List<String> binaryFilesPaths = new List<string>();

            try
            {
                string patchContent = System.IO.File.ReadAllText(patchPath);
                string[] changes = patchContent.Split(new string[] {"Index:"}, StringSplitOptions.None); //Regex.Split("{Index:}+", patchContent);
                

                foreach (var change in changes)
                {
                    if (change.Contains("Cannot display: file marked as a binary type."))
                    {
                        binaryFilesPaths.Add(change.Split('\r').First().Trim());             
                    }
                }
            }
            catch (Exception)
            {
                
                
            }

            return binaryFilesPaths.Distinct().ToList();

        }
    }
}
