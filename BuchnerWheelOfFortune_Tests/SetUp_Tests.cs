using BuchnerWheelOfFortune;
using BuchnerWheelOfFortune.Interfaces;
using BuchnerWheelOfFortune.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BuchnerWheelOfFortune_Tests
{
    [TestClass]
    public class SetUp_Tests
    {
        [TestMethod]
        public void TestCanFail()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CanAskForOnePlayer()
        {
            using var output = new StringWriter();
            using var input = new StringReader("1");
            var sut = new GetPlayers();
            Console.SetOut(output);
            Console.SetIn(input);

            sut.GetPlayerAmount();

            var expected = String.Format("{0}{1}", WFConstants.HowManyPlayers, Environment.NewLine);
            Assert.AreEqual<string>(expected, output.ToString());
        }

        [TestMethod]
        public void CanAskForTwoPlayer()
        {
            using var output = new StringWriter();
            using var input = new StringReader("2");
            var sut = new GetPlayers();
            Console.SetOut(output);
            Console.SetIn(input);

            sut.GetPlayerAmount();

            var expected = String.Format("{0}{1}", WFConstants.HowManyPlayers, Environment.NewLine);
            Assert.AreEqual<string>(expected, output.ToString());
        }

        [TestMethod]
        public void ReAsksIfZeroPlayesr()
        {
            
            using var output = new StringWriter();
            var sut = new GetPlayers();
            Console.SetOut(output);

            sut.GetPlayerAmount();

            var expected = String.Format("{0}{1}", 
                WFConstants.HowManyPlayers, 
                Environment.NewLine);
            Assert.AreEqual<string>(expected, output.ToString());
        }
    }
}
