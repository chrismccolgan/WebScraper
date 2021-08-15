﻿using System;
using System.Net;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("http://www.google.com/");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}
