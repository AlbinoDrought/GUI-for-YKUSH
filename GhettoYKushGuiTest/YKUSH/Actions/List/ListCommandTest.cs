using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhettoYKushGuiTest.YKUSH.Actions.List
{
    [TestClass]
    public class ListCommandTest
    {
        [TestMethod]
        public void TestParse()
        {
            var lines = new string[]
            {
                "",
                "",
                "Attached YKUSH Boards:",
                "",
                "YKC6058",
                "",
                "",
                "",
            };

            var output = (new GhettoYkushGui.YKUSH.Actions.List.ListCommand()).Parse(lines);
            Assert.AreEqual(1, output.Devices.Count);
            var device = output.Devices[0];
            Assert.AreEqual("YKC6058", device.SerialNumber);
        }
    }
}
