using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace Scraper
{
    class Program
    {
        static ScrapingBrowser _browser = new ScrapingBrowser();

        static void Main(string[] args)
        {

            GetHtml("https://newyork.craigslist.org/d/computer-gigs/search/cpg");

        }
        static HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
