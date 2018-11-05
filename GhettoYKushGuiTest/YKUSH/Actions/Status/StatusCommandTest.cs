using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhettoYKushGuiTest.YKUSH.Actions.Status
{
    [TestClass]
    public class StatusCommandTest
    {
        [TestMethod]
        public void TestCommand()
        {
            var command = new GhettoYkushGui.YKUSH.Actions.Status.StatusCommand();

            Assert.AreEqual("-g 1", command.Arguments(1));
            Assert.AreEqual("-g 2", command.Arguments(2));
            Assert.AreEqual("-g 3", command.Arguments(3));
        }

        [TestMethod]
        public void TestParse()
        {
            var lines = new string[]
            {
                "",
                "",
                "Downstream port 2 is ON",
                "",
                "",
            };

            var output = (new GhettoYkushGui.YKUSH.Actions.Status.StatusCommand()).Parse(lines);

            Assert.AreEqual(true, output.Enabled);
            Assert.AreEqual(2, output.Port);
        }

        [TestMethod]
        public void TestParseOff()
        {
            var lines = new string[]
            {
                "",
                "",
                "Downstream port 3 is OFF",
                "",
                "",
            };

            var output = (new GhettoYkushGui.YKUSH.Actions.Status.StatusCommand()).Parse(lines);

            Assert.AreEqual(false, output.Enabled);
            Assert.AreEqual(3, output.Port);
        }
    }
}
