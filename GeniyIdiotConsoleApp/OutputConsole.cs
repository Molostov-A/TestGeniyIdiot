using System;
using System.Collections.Generic;
using GeniyIdiot.Common.Models;

namespace GeniyIdiotConsoleApp
{
    public static class OutputConsole
    {
        public static void ResultsTestInTable(List<TestResult> testResults)
        {
            const string markup1 = "||{0,-15}||{1,-20}||{2,-15}||{3,-25}||";
            const string markup2 = "||{0,-15}||{0,-20}||{0,-15}||{0,-25}||";
            Console.WriteLine();
            Console.WriteLine("Выводим таблицу результатов тестирования");
            Console.WriteLine(markup1, "Имя", "Количество баллов", "Диагноз", "Время");
            Console.WriteLine(markup2, "---");
            foreach (var res in testResults)
            {
                Console.WriteLine(markup1, res.Patient.Name, res.Scores, res.Diagnosis, res.Time);
            }
        }
    }
}
