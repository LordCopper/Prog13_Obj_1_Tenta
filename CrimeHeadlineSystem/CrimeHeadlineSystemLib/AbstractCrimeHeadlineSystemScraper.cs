using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public abstract class AbstractCrimeHeadlineSystemScraper : ICrime
    {
        public virtual string GetUrl { get; set; }
        public virtual string GetXpath { get; set; }
        public virtual string CrimeHeadline { get; set; }

        public virtual void ReturnTopCrime(){}

        public void ReadTopCrime()
        {
            var getHtmlWeb = new HtmlWeb();
            string crimeHeadline = string.Empty;

            HtmlDocument document = getHtmlWeb.Load(String.Format(GetUrl));

            var nodes = document.DocumentNode.SelectNodes(GetXpath);
            foreach (var headline in nodes)
            {
                crimeHeadline = headline.InnerText;
            }

            CrimeHeadline=crimeHeadline;
        }
    }
}
