using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramworkLayer
{
    public class TestsDetails
    {
        private string project1Name;
        private string project1TestID1 = "P1";
        private string project1TestID2 = "P2";
        private string project1TestName1 = "Test1";
        private string project1TestName2 = "Test2";

        private List<string> testID;
        private List<Action> TestMethodDeligate;

        public List<string> TestID
        {
            get { return testID; }
        }


        public void Project1()
        {
            testID = new List<string>
            {
                project1TestID1,
                project1TestID2
            };
            TestMethodDeligate = new List<Action>
            {
                Test1.RunTest
            };
        }

    }
}
