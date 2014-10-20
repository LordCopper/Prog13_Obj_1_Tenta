using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class ScrapeUtryckning : AbstractCrimeHeadlineSystemScraper
    {        
        private CrimeHeadlineSystem mediator;

        public ScrapeUtryckning(CrimeHeadlineSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterScraper(this);
        }

        public override void ReturnTopCrime()
        {
            ReadTopCrime();
            mediator.FoundCrime("Utryckning", CrimeHeadline);
        }
        public override string GetUrl
        {
            get { return "http://www.utryckning.se "; }
        }

        public override string GetXpath
        {
            get { return "//*[@id='homepage']/div[1]/div[1]/h1/a"; }
        }

    }
}
