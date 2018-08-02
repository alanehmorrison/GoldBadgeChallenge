using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_2;

namespace Challenge_2_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //I unit tested my properties for practice.

        ClaimRepository claimRepo = new ClaimRepository();

        [TestMethod]
        public void Challenge2_ClaimID_ShouldReturnInt()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            int actual = car.Id;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Challenge2_ClaimType_ShouldReturnString()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            string actual = car.Type;
            string expected = "car";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Challenge2_ClaimDescription_ShouldReturnString()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            string actual = car.Description;
            string expected = "car accident";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Challenge2_ClaimAmount_ShouldReturnInt()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            int actual = car.Amount;
            int expected = 400;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Challenge2_ClaimDate_ShouldReturnDateTime()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            DateTime actual = car.Incident;
            DateTime expected = DateTime.Parse("04/25/2018");

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Challenge2_ClaimReport_ShouldReturnDateTime()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            DateTime actual = car.Report;
            DateTime expected = DateTime.Parse("04/27/2018");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Challenge2_ClaimRepo_ShouldReturnQueueWithCount1()
        {
            Claim one = new Claim(1, "house", "home burned down", 50000, DateTime.Parse("05/28/2018"), DateTime.Parse("05/28/2018"));
            claimRepo.Add(one);

            var actual = claimRepo.GetClaimList().Count;
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Challenge2_claimRepo_ShouldReturnList()
        {
            var actual = claimRepo.GetClaimList().Count;
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Challenge2_claimRepo_ShouldRemoveCurrentClaimFromQueue()
        {
            Claim one = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));
            Claim two = new Claim(2, "house", "home burned down", 50000, DateTime.Parse("05/28/2018"), DateTime.Parse("05/28/2018"));

            claimRepo.Add(one);
            claimRepo.Add(two);
            claimRepo.CurrentClaimFinished();

            var actual = claimRepo.GetClaimList().Count;
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}
