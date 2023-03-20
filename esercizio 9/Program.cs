using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire dimensione");
            int d=int.Parse(Console.ReadLine());
            int[] a = new int[d];
            int[] b=new int[d];
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine("Inserire numero: ");
                a[i]=int.Parse(Console.ReadLine());
                inv(a, b, ref d);
                Console.WriteLine(b);
            }

        }
        public static void inv(int []a, int []b, ref int d)
        {
            for(int i = 0; i < d; i++)
            {
                a[i] = b[d];
            }
        }
    }
}
