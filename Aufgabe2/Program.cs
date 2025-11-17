using System;
using System.Threading;

namespace Project2_RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // add your code here




        }

        static void CreateRandomNumers()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rnum = rnd.Next(1, 100);
                // add your code here



                
            }
        }
    }
}