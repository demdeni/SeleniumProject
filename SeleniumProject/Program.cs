using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramworkLayer;
using NUnit.Framework;

namespace SeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBase runproject = new TestBase();
            runproject.TestInitialize();
        }
    }
}
