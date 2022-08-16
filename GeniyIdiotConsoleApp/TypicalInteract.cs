using System;

namespace GeniyIdiotConsoleApp
{
    public class TypicalInteract
    {
        public bool BinaryAsk(string ask, string replyIfYes, string replyIfNo)
        {
            var desireToSelfTested = true;
            Console.WriteLine();
            Console.WriteLine($"{ask} (да / нет)");
            while (true)
            {
                var answer = Console.ReadLine()?.ToLower();
                if (answer == "да")
                {
                    if (replyIfYes != "")
                        Console.WriteLine(replyIfYes);
                    break;
                }
                if (answer == "нет")
                {
                    desireToSelfTested = false;
                    if (replyIfNo != "")
                        Console.WriteLine(replyIfNo);
                    break;
                }
                Console.WriteLine("Необходимо ввести \"да\" или \"нет\".");
            }
            return desireToSelfTested;
        }
        public bool BinaryAsk(string ask)
        {
            var desireToSelfTested = true;
            Console.WriteLine();
            Console.WriteLine($"{ask} (да/нет)");
            while (true)
            {
                var answer = Console.ReadLine().ToLower();
                if (answer == "да")
                {
                    break;
                }
                if (answer == "нет")
                {
                    desireToSelfTested = false;
                    break;
                }
                Console.WriteLine("Необходимо ввести \"да\" или \"нет\".");
            }
            return desireToSelfTested;
        }
    }

}
