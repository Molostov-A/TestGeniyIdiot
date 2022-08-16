using System;

namespace GeniyIdiot.Common
{
    public static class MyConstant
    {
        public static bool StartingGreeting = true;
        public static bool AdminAutorisation = false;
        public static string NameApp => "Гений Идиот";
        public static string IncorrectAnswer => "2147483640";
        public static string Greeting => String.Format($@"Добро пожаловать в приложение ""{NameApp}""!");
        public static int TimeLimitAnswer => 10; //секунды
    }
}
