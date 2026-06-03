using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sistem_tarihi_saati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);

            }
        }
    }
}
