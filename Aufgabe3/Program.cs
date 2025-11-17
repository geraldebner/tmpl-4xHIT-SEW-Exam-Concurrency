using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;

class Program
{
    
    static void Main(string[] args)
    {

        // 2 Writer-Threads starten und 1 Reader-Thread starten
       
        // add your code here



        Console.WriteLine("Drücke ENTER zum Beenden...");
        Console.ReadLine();
    }

    static void TextProducer()
    {
        Random rnd = new Random();
        while (true)
        {
            string randomText = $"[{Thread.CurrentThread.Name}] Zufall: {rnd.Next(1000)}";
            
            // add your code here
            
        }
    }

    static void TextConsumer()
    {
        while (true)
        {
            string item = "";

            // add your code here





        }
    }
}