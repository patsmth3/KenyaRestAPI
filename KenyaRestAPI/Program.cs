﻿using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KenyaRestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Quotes.KanyeQuote();
            
            Quotes.RonQuote();
        }
    }
}