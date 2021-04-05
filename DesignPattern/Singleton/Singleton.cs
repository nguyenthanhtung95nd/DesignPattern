using System;

namespace CreationalDesignPattern.Singleton
{
    public class Singleton
    {
        // For testing
        private static int counter = 0;
        private static Singleton _instance;

        protected Singleton()
        {
            // For testing
            counter++;
            Console.WriteLine($"Number of instance {counter}");
        }

        public static Singleton Instance()
        {
            return _instance ??= new Singleton();
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}