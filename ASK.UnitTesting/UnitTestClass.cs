using ASK.TestDrivenDevelopment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASK.UnitTesting
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void UtcDate()
        {
            var date = new DateTime(2012, 02, 29).ToUniversalTime();

            Assert.AreEqual($"101.02.29", date.UtcDate());
        }

        [TestMethod]
        public void LittleBitDate()
        {
            var date = new DateTime(2012, 02, 29);

            Assert.AreEqual($"101.02.29", date.LittleBitDate());
        }

        [TestMethod]
        public void ShortDate()
        {
            var date = new DateTime(2012, 02, 29);

            Assert.AreEqual($"101�~02��29��", date.ShortDate());
        }

        [TestMethod]
        public void LognData()
        {
            var date = new DateTime(2012, 02, 29);

            Assert.AreEqual($"����101�~02��29��", date.LognData());
        }

        [TestMethod]
        public void LongDateAndWeek()
        {
            var date = new DateTime(2012, 02, 29);


            Assert.AreEqual("����101�~02��29�� �g�T", date.LongDateAndWeek());
        }


        [TestMethod]
        public void LongDateAndLongWeek()
        {
            var date = new DateTime(2012, 02, 29);
            

            Assert.AreEqual("����101�~02��29�� �P���T", date.LongDateAndLongWeek());
        }
    }
}
