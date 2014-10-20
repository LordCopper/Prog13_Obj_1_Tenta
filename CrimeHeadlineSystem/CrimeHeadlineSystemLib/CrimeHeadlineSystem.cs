using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class CrimeHeadlineSystem
    {
        private ICrime scraper;

        internal void RegisterScraper(ICrime scraper)
        {
            this.scraper = scraper;
        }
        public void FoundCrime(string site, string title)
        {
            Console.WriteLine(site + ": " + title);
        }
    }
}
