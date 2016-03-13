using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReviewHook
{
    public class SvnCommands
    {
        public string GetCommitMessageTemplate(string workingCopyPath)
        {
            string strCmdText;
            strCmdText = @"propget tsvn:logtemplatecommit";

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.FileName = "svn";
            process.StartInfo.WorkingDirectory = workingCopyPath;
            process.StartInfo.Arguments = strCmdText;
            process.Start();
            process.WaitForExit();

            string commitTemplate = string.Empty;
            if (process.ExitCode == 0)
            {
                commitTemplate = process.StandardOutput.ReadToEnd();
            }

            return commitTemplate;
        }
    }
}
