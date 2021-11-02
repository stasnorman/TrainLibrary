using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainLibraryKek;

namespace UnitDataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PostString()
        {
            TimeSpan[] time = { new TimeSpan(10, 00, 00), new TimeSpan(11, 00, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] durationSet = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(9, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(17, 0, 0);
            int consul = 30;

            var getActual = Calculations.AvailablePeriod(time, durationSet, beginWorkingTime, endWorkingTime, consul);
            var expected = Calculations.AvailablePeriod(time, durationSet, new TimeSpan(9, 0, 0), new TimeSpan(9, 0, 0), 30);

            Assert.AreEqual(expected, getActual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TimeSpan[] time = { new TimeSpan(10, 00, 00), new TimeSpan(11, 00, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] durationSet = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(9, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(17, 0, 0);
            int consul = 30;

            var getActual = Calculations.AvailablePeriod(time, durationSet, new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), consul);
            var expected = Calculations.AvailablePeriod(time, durationSet, new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), 30);

            Assert.AreEqual(expected, getActual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TimeSpan[] time = { new TimeSpan(10, 00, 00), new TimeSpan(11, 00, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] durationSet = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(9, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(17, 0, 0);
            int consul = 30;

            var getActual = Calculations.AvailablePeriod(time, durationSet, new TimeSpan(9, 0, 0), new TimeSpan(-9, 0, 0), -10);
            var expected = Calculations.AvailablePeriod(time, durationSet, new TimeSpan(9, 0, 0), new TimeSpan(-9, 0, 0), 30);

            Assert.IsNotNull(getActual);
        }

        [TestMethod]
        public void TestMethod4()
        {
        }

        [TestMethod]
        public void TestMethod5()
        {
        }

    }
}
