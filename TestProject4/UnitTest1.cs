using System;
using Learning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTestCompany
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument Exception NOT Thrown")]
        public void TestWrongCountryCode()
        {

            var testCompany = new Learning.Company("company", 12, "France");
            Console.WriteLine(testCompany.CountryCode);

        }

        [TestMethod]
        public void TestGoodCountryCode()
        {
           var testCompany = new Learning.Company("company", 12, "Fr");

           Assert.AreEqual("FR" , testCompany.CountryCode);
           Console.WriteLine(testCompany.CountryCode);
        }

        [ExpectedException(typeof(ArgumentException), "Argument Exception NOT Thrown")]
        [TestMethod]
        public void TestNumsInCountryCode()
        {
            var testCompany = new Learning.Company("company", 12, "99");
        }

        [ExpectedException(typeof(ArgumentException), "Argument Exception NOT Thrown")]
        [TestMethod]
        public void TestSpecialsInCountryCode()
        {
            var testCompany = new Learning.Company("company", 12, "*&");
        }

        [ExpectedException(typeof(ArgumentException), "Argument Exception NOT Thrown")]
        [TestMethod]
        public void TestSpaceInCountryCode()
        {
            var testCompany = new Learning.Company("company", 12, "  ");
        }
    }
}
