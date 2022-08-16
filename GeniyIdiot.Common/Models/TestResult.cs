using System;

namespace GeniyIdiot.Common.Models
{
    public class TestResult
    {
        public User Patient { get; set; }
        public double Scores { get; set; }
        public string Diagnosis { get; set; }
        public DateTime Time { get; set; }


        public TestResult(User patient, double scores, string diagnosis)
        {
            Patient = patient;
            Scores = Math.Round(scores, 2);
            Diagnosis = diagnosis;
            Time = DateTime.Now;
        }

    }
}
