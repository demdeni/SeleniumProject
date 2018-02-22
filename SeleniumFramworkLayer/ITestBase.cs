using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramworkLayer
{
    interface ITestBase
    {
        void TestInitialize();

        void TestExecution();

        void MultipleTestExecution(int[] testIndex);

        void TestCleanup();

        void OneTearDown();

        void OnSetUp();

    }
}
