using System;
using System.Threading;

namespace Project1_PrintRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // add your code here



            
        }

        static void PrintRandomNumbers(int amountOfRandomNumbers)
        {
            Random rnd = new Random();
            for (int i = 0; i < amountOfRandomNumbers; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {rnd.Next(1, 100)}");
                Thread.Sleep(50); // kleine Pause für bessere Ausgabe
            }
        }
    }
}