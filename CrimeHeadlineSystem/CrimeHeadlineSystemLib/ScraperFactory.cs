using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class ScraperFactory
    {
        public static ICrime CreateCrimeScraper(string scraperToCreate, CrimeHeadlineSystem mediator)
        {
            ICrime service = null;
            switch (scraperToCreate)
            {
                case "Polisen":
                    service = new ScrapePolisen(mediator);
                    break;
                case "Utryckning":
                    service = new ScrapeUtryckning(mediator);
                    break;
            }
            return service;
        }
    }
}
