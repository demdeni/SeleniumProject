using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramworkLayer;

namespace SeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBase runproject = new TestBase();
            runproject.TestExecution();
        }
    }
}
