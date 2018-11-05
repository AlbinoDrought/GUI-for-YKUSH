using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhettoYkushGui.YKUSH.Actions.Down
{
    public class DownCommand
    {
        public string Arguments(int port)
        {
            return "-d " + port;
        }
    }
}
