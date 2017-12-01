﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestVSSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;

            Console.Write($"Hi! Huy {version.Build} {version.Major} {version.Minor} {version.Revision}");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
