using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetSingleton();

            Singleton singleton2 = Singleton.GetSingleton();

            Singleton singleton3 = Singleton.GetSingleton();

            Singleton singleton4 = Singleton.GetSingleton();

            Singleton singleton5 = Singleton.GetSingleton();
        }
    }
}
