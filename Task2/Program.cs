using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "C:\\New folder\\test.txt";

                int count = 0;
                List<string> status = new List<string>();

                for (int i = 0; i < 5; i++)
                {
                    count++;
                    Console.WriteLine("Input your current status at {0}:", DateTime.Now);
                    string current = Console.ReadLine();
                    Thread.Sleep(5000);

                    status.Add(current + " at " + DateTime.Now);
                }
                status.Reverse();
                File.AppendAllLines(filePath, status);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
