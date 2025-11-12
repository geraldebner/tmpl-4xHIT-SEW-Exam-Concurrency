using System;
using System.IO;
using System.Threading;

namespace Project3_LineCounter
{
    class Program
    {
        static int totalXCount = 0;
        //Lösung static object lockObj = new object();

        static void Main(string[] args)
        {
            string filePath = "bigfile.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Datei nicht gefunden!");
                return;
            }

            int totalLines = File.ReadLines(filePath).Count();
            int threadCount = totalLines / 100; // Jeder Thread liest max. 100 Zeilen


            /*
            //Lösung 
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                int startLine = (i + 1) * 100; // Thread 1 -> ab Zeile 100, Thread 2 -> ab 200, ...
                threads[i] = new Thread(() => ProcessFilePart(filePath, startLine, 100));
                threads[i].Start();
            }

            foreach (var t in threads)
                t.Join();
            */

            Console.WriteLine($"Gesamtanzahl von 'x': {totalXCount}");
        }

        static void ProcessFilePart(string filePath, int startIndex, int maxLines)
        {
            int localCount = 0;
            int currentLine = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Überspringe Zeilen bis zum StartIndex
                while (currentLine < startIndex && !reader.EndOfStream)
                {
                    reader.ReadLine();
                    currentLine++;
                }

                // Lese maxLines ab StartIndex
                int linesRead = 0;
                while (linesRead < maxLines && !reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    localCount += CountX(line);
                    linesRead++;
                }
            }

            // Race Condition vermeiden
            lock (lockObj)
            {
                totalXCount += localCount;
            }
        }

        static int CountX(string line)
        {
            int count = 0;
            foreach (char c in line)
            {
                if (c == 'x' || c == 'X') count++;
            }
            return count;
        }
    }
}
