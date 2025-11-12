using System;
using System.IO;
using System.Threading;

class Program
{
    static string filePath = "test.txt";
    static ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();
    static object consoleLock = new object();

    static void Main(string[] args)
    {
        // Datei erstellen, falls nicht vorhanden
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "");
        }

        // 3 Writer-Threads starten
        for (int i = 0; i < 3; i++)
        {
            Thread writerThread = new Thread(FileWrite);
            writerThread.Name = $"Writer-{i + 1}";
            writerThread.Start();
        }

        // 2 Reader-Threads starten
        for (int i = 0; i < 2; i++)
        {
            Thread readerThread = new Thread(FilePrint);
            readerThread.Name = $"Reader-{i + 1}";
            readerThread.Start();
        }

        Console.WriteLine("Drücke ENTER zum Beenden...");
        Console.ReadLine();
    }

    static void FileWrite()
    {
        Random rnd = new Random();
        while (true)
        {
            rwLock.EnterWriteLock(); // Exklusiver Zugriff: kein Lesen erlaubt
            try
            {
                string randomText = $"[{Thread.CurrentThread.Name}] Zufall: {rnd.Next(1000)}";
                File.AppendAllText(filePath, randomText + Environment.NewLine);

                lock (consoleLock)
                {
                    Console.WriteLine($"--> {Thread.CurrentThread.Name} hat geschrieben: {randomText}");
                }
            }
            finally
            {
                rwLock.ExitWriteLock();
            }

            Thread.Sleep(1000); // 1 Sekunde warten
        }
    }

    static void FilePrint()
    {
        long lastPosition = 0;
        while (true)
        {
            rwLock.EnterReadLock(); // Mehrere Leser erlaubt, aber kein Writer
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    fs.Seek(lastPosition, SeekOrigin.Begin);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            lock (consoleLock)
                            {
                                Console.WriteLine($"[{Thread.CurrentThread.Name}] liest: {line}");
                            }
                        }
                        lastPosition = fs.Position;
                    }
                }
            }
            finally
            {
                rwLock.ExitReadLock();
            }

            Thread.Sleep(500); // alle 0,5 Sekunden prüfen
        }
    }
}