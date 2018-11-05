using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhettoYkushGui.YKUSH.Actions.Up
{
    public class UpCommand
    {
        public string Arguments(int port)
        {
            return "-u " + port;
        }
    }
}
