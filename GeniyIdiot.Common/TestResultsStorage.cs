using System.Collections.Generic;
using GeniyIdiot.Common.Models;

namespace GeniyIdiot.Common
{
    public class TestResultsStorage
    {
        private static JsonProvider storage = new("test_results");
        private List<TestResult> TestResults { get; set; }

        public TestResultsStorage()
        {
            TestResults = storage.Read<List<TestResult>>();
        }

        public List<TestResult> GetTestResults()
        {
            return TestResults;
        }

        public void Reset()
        {
            TestResults = new List<TestResult>();
            Save();
        }

        public void Add(TestResult testResult)
        {
            TestResults.Add(testResult);
            Save();
        }

        private void Save()
        {
            storage.Write(TestResults);
        }


    }
}
