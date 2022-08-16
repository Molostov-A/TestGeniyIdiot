using System;
using System.Diagnostics;
using System.Threading;

namespace GeniyIdiotConsoleApp
{
    public class Reader //замена консоли для ввода по таймеру
    {
        private static Thread inputThread; //многопотоковый ввод
        private static AutoResetEvent getInput, gotInput;
        private static string input;

        static Reader()
        {
            getInput = new AutoResetEvent(false); // эвент до
            gotInput = new AutoResetEvent(false); // эвент после
            inputThread = new Thread(reader);
            inputThread.IsBackground = true;
            inputThread.Start();
        }

        private static void reader()
        {
            while (true)
            {
                getInput.WaitOne(); // эвент - подождать
                input = Console.ReadLine();
                gotInput.Set(); // эвент - установить
            }
        }

        // опустить параметр для чтения строки без тайм-аута
        //

        public static (string,int) ReadLine(int timeOutSec = Timeout.Infinite)
        {

            Stopwatch stopWatch = new Stopwatch(); // секундомер
            stopWatch.Start(); // запустить секундомер
            int remainsTime = 0;
            var timeOutMiliSec = timeOutSec * 1000;

            getInput.Set();
            bool success = gotInput.WaitOne(timeOutMiliSec);
            if (success)
            {
                remainsTime = timeOutMiliSec - Convert.ToInt32(stopWatch.Elapsed.TotalMilliseconds);
                if (remainsTime < 0) remainsTime = 0;
                return (input, remainsTime / 1000);
            }
            else
                throw new TimeoutException("User did not provide input within the timelimit.");
        }
    }
}