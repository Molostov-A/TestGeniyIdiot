using System;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    public class Verification
    {
        private TypicalInteract typicalInteract = new();
        UsersStorage usersStorage = new();
        public int CheckNumericInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Пожалуйста, введите число от -2*10^9 до 2*10^9!");
                }
                catch
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
        }

        public int CheckNumericInputTimer(int timeSec)
        {
            int intAnswer;
            while (true)
            {
                string answer;
                try
                {
                    (answer,timeSec) = Reader.ReadLine(timeSec);
                    if (!int.TryParse(answer, out intAnswer))
                    {
                        Console.WriteLine("Пожалуйста, введите число!");
                    }
                    else
                    {
                        intAnswer = Convert.ToInt32(answer);
                        return intAnswer;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Пожалуйста, введите число от -2*10^9 до 2*10^9!");
                }
                catch (TimeoutException)
                {
                    answer = MyConstant.IncorrectAnswer;
                    intAnswer = Convert.ToInt32(answer);
                    return intAnswer;
                }
                catch
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
        }

        public bool CheckInputPassword(string nameUserSpecialist)
        {
            while (true)
            {
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();
                if (usersStorage.Autorization(password, nameUserSpecialist))
                {
                    Console.WriteLine("Введён верный пароль.");
                    return true;
                }
                if (!typicalInteract.BinaryAsk("Введён неверный пароль.\nЖелаете повторить ввод пароля?"))
                {
                    return false;
                }
            }
        }
        public bool EmptyName(string nameUser)
        {
            if (nameUser != "")
            {
                return false;
            }
            return true;
        }
    }
}
