using GhettoYkushGui.YKUSH.Actions.Down;
using GhettoYkushGui.YKUSH.Actions.Status;
using GhettoYkushGui.YKUSH.Actions.Up;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace GhettoYkushGui.YKUSH
{
    public class YKushState
    {
        public YKushWrapper Wrapper;
        public string NameFile;
        public IDictionary<int, PortState> PortState = new Dictionary<int, PortState>();

        public static int PORT_MIN = 1;
        public static int PORT_MAX = 3;

        public YKushState()
        {
            for (var i = PORT_MIN; i <= PORT_MAX; i += 1)
            {
                PortState[i] = new PortState()
                {
                    Port = i,
                    Enabled = false,
                    Name = "Port " + i,
                };
            }
        }

        public void SaveNames()
        {
            List<string> data = new List<string>();

            foreach (var portState in this.PortState.Values)
            {
                data.Add(portState.Port + "," + portState.Name);
            }

            File.WriteAllLines(NameFile, data);
        }

        public void LoadNames()
        {
            if (!File.Exists(NameFile))
            {
                return;
            }

            using (TextFieldParser parser = new TextFieldParser(NameFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length < 2)
                    {
                        continue;
                    }

                    var port = Convert.ToInt32(fields[0]);
                    var name = String.Join(",", fields, 1, fields.Length - 1);
                    
                    if (this.PortState.ContainsKey(port))
                    {
                        this.PortState[port].Name = name;
                    }
                }
            }
        }

        public void Refresh()
        {
            var command = new StatusCommand();

            foreach (var portState in this.PortState.Values)
            { 
                var output = Wrapper.Run(command.Arguments(portState.Port));
                var statusOutput = command.Parse(output);

                PortState[portState.Port].Enabled = statusOutput.Enabled;
            }
        }

        public void Up(int port)
        {
            var command = new UpCommand();

            Wrapper.Run(command.Arguments(port));

            PortState[port].Enabled = true;
        }

        public void Down(int port)
        {
            var command = new DownCommand();

            Wrapper.Run(command.Arguments(port));

            PortState[port].Enabled = false;
        }
    }
}
