using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GhettoYkushGui.YKUSH.Actions.Status
{
    public class StatusCommand
    {
        public string Arguments(int port)
        {
            return "-g " + port;
        }

        public StatusOutput Parse(IEnumerable<string> results)
        {
            var statusOutput = new StatusOutput();

            foreach (var line in results)
            {
                var trimmed = line.Trim();

                if (trimmed.Length <= 0)
                {
                    continue;
                }

                var match = Regex.Match(
                    trimmed,
                    @"Downstream port (\d) is (OFF|ON)"
                );
                
                if (!match.Success)
                {
                    continue;
                }

                var groups = match.Groups;

                var port = Convert.ToInt32(groups[1].Value);
                var enabled = groups[2].Value == "ON";

                statusOutput.Port = port;
                statusOutput.Enabled = enabled;
                break;
            }

            return statusOutput;
        }
    }
}
