﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@".\OFXFile.txt");
            var ticaXml = reader.ReadToEnd();

            string pattern = @"([^<]+>)(.*[0-9A-Z-]*[^\s\n])";
            string substitution = "$1$2</$1";

            string input = ticaXml;
            RegexOptions options = RegexOptions.Multiline;

            Regex regex = new Regex(pattern, options);

            string result = regex.Replace(input, substitution);

            Console.Write(result);

            Console.ReadKey();
        }
    }
}
