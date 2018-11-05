using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhettoYkushGui.YKUSH.Actions.List
{
    public class ListCommand
    {
        public string Arguments()
        {
            return "-l";
        }

        public ListOutput Parse(IEnumerable<string> results)
        {
            var listOutput = new ListOutput();

            bool foundAttached = false;

            foreach (var line in results)
            {
                var trimmed = line.Trim();

                if (trimmed.Length <= 0)
                {
                    continue;
                }

                if (!foundAttached)
                {
                    if (trimmed.Contains("Attached"))
                    {
                        foundAttached = true;
                    }

                    continue;
                }

                var serial = trimmed;

                listOutput.Devices.Add(new Device
                {
                    SerialNumber = serial,
                });
            }

            return listOutput;
        }
    }
}
