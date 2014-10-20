using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class ScrapePolisen : AbstractCrimeHeadlineSystemScraper
    {
        private CrimeHeadlineSystem mediator;

        public ScrapePolisen(CrimeHeadlineSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterScraper(this);
        }
        public override void ReturnTopCrime()
        {
            ReadTopCrime();
            mediator.FoundCrime("Polisen", CrimeHeadline);
        }
        public override string GetUrl
        {
            get { return "http://polisen.se/"; }
        }

        public override string GetXpath
        {
            get { return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }
    }
}
