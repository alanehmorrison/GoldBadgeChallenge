using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Unit_Tests
{
    [TestClass]
    public class OutingsRepo_Test
    {
        OutingRepository outRepo = new OutingRepository();

        [TestMethod]
        public void Challenge1_OutingsRepo_ShouldReturnQueuewithCount1()
        {
            Outings one = new Outings((Event)1, 10, "01/22/2018", 20, 200);
            outRepo.AddOutingToList(one);

            var actual = outRepo.GetList().Count;
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Challenge1_OutingsRepo_ShouldReturnList()
        {
            var actual = outRepo.GetList().Count;
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Challenge1_OutingsRepo_ShouldTotalAll()
        {
            Outings one = new Outings((Event)1, 10, "01/22/2018", 20, 200);
            Outings two = new Outings((Event)1, 5, "01/22/2018", 20, 100);
            outRepo.AddOutingToList(one);
            outRepo.AddOutingToList(two);

            var actual = outRepo.TotalAllOutings();
            var expected = 300;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Challenge1_OutingsRepo_ShouldTotalAllByType()
        {
            Outings one = new Outings((Event)1, 10, "01/22/2018", 20, 200);
            Outings two = new Outings((Event)1, 5, "01/22/2018", 20, 100);
            outRepo.AddOutingToList(one);
            outRepo.AddOutingToList(two);

            var actual = outRepo.TotalAllOutingsByType((Event)1);
            var expected = 300;

            Assert.AreEqual(actual, expected);
        }

    }
}
