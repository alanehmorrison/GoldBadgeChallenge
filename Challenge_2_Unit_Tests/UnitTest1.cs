using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_2;

namespace Challenge_2_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Claim_ClaimID_ShouldReturnInt()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            int actual = car.Id;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Claim_ClaimType_ShouldReturnString()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            string actual = car.Type;
            string expected = "car";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Claim_ClaimDescription_ShouldReturnString()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            string actual = car.Description;
            string expected = "car accident";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Claim_ClaimAmount_ShouldReturnInt()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            int actual = car.Amount;
            int expected = 400;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Claim_ClaimDate_ShouldReturnDateTime()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            DateTime actual = car.Incident;
            DateTime expected = DateTime.Parse("04/25/2018");

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Claim_ClaimReport_ShouldReturnDateTime()
        {
            Claim car = new Claim(1, "car", "car accident", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"));

            DateTime actual = car.Report;
            DateTime expected = DateTime.Parse("04/27/2018");

            Assert.AreEqual(expected, actual);
        }
    }
}
