using System;
using System.Threading;

namespace Project2_RandomNumbers
{
    class Program
    {
        public static List<int> RandomNumberList = new List<int>();
        static void Main(string[] args)
        {
            // ADD your Code Here



        /*
            foreach( int rnum in RandomNumberList)
            {
                Console.WriteLine(rnum);
            }

            */
        }

        static void CreateRandomNumers()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rnum = rnd.Next(1, 100);
                //RandomNumberList.Add();
            }
        }
    }
}