using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GhettoYkushGui
{
    public class YKushWrapper
    {
        public string ExecutablePath { get; set; }

        public IEnumerable<string> Run(string args)
        {
            var process = Process.Start(new ProcessStartInfo
            {
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                FileName = this.ExecutablePath,
                CreateNoWindow = true,
            });

            var output = new List<string>();

            while (!process.StandardOutput.EndOfStream)
            {
                output.Add(process.StandardOutput.ReadLine());
            }

            if (!process.HasExited)
            {
                process.Kill();
            }

            return output;
        }
    }
}
