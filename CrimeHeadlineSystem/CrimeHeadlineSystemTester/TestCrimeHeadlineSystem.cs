using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrimeHeadlineSystemLib;

namespace CrimeHeadlineSystemTester
{
    [TestClass]
    public class TestCrimeHeadlineSystem
    {
        [TestMethod]
        public void Test_that_ScraperPolisen_returns_right_title_from_Polisen()
        {
            CrimeHeadlineSystem crimeSystem = new CrimeHeadlineSystem();
            ICrime crimesite = ScraperFactory.CreateCrimeScraper("Polisen",crimeSystem);

            crimesite.ReturnTopCrime();
        }
        [TestMethod]
        public void Test_that_ScraperUtryckning_returns_get_right_title_from_Utryckning()
        {
            CrimeHeadlineSystem crimeSystem = new CrimeHeadlineSystem();
            ICrime crimesite = ScraperFactory.CreateCrimeScraper("Utryckning", crimeSystem);

            crimesite.ReturnTopCrime();
        }
    }
}
