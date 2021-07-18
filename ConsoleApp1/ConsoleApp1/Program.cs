using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            List<int> name = new List<int>(n);
           
            for(int i=0;i<n;i++)
            {
                name.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i=0;i<n;i++)
            {
                Console.Write(name[i]+" ");
            }    
        }
    }
}
