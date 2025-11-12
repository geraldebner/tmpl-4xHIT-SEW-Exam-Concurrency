using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;

class Program
{
    //Lösung static ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
    //Lösung static object consoleLock = new object();

    static void Main(string[] args)
    {
        // Datei vorbereiten
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "");
        }

        // 2 Writer-Threads starten und 1 Reader-Thread starten
        /* Lösung
        for (int i = 0; i < 2; i++)
        {
            Thread writerThread = new Thread(QueueWriter);
            writerThread.Name = $"Writer-{i + 1}";
            writerThread.Start();
        }

        // 1 Reader-Thread starten
        Thread readerThread = new Thread(QueueReader);
        readerThread.Name = "Reader";
        readerThread.Start();
        */

        Console.WriteLine("Drücke ENTER zum Beenden...");
        Console.ReadLine();
    }

    static void TextProducer()
    {
        Random rnd = new Random();
        while (true)
        {
            string randomText = $"[{Thread.CurrentThread.Name}] Zufall: {rnd.Next(1000)}";
            
            // Add code here
            /* Lösung
            queue.Enqueue(randomText);

            lock (consoleLock)
            {
                Console.WriteLine($"--> {Thread.CurrentThread.Name} hat in die Queue gelegt: {randomText}");
            }

            Thread.Sleep(1000); // 1 Sekunde warten

            */

            
        }
    }

    static void TextConsumer()
    {
        while (true)
        {
            string item = "";

            // Add code here to get strings from queue and write to console
            /* Lösung            

            if (queue.TryDequeue(out string item1))
            {
               
                lock (consoleLock)
                {
                    Console.WriteLine($"[{Thread.CurrentThread.Name}] hat aus Queue gelesen und in Datei geschrieben: {item}");
                }
            }
            
            */

            Thread.Sleep(200); 
        }
    }
}