using clase05.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsNotas notas = new ClsNotas(10, 9, 10, 10, 9, 9);

            Console.WriteLine(notas.ToString());
            Console.ReadLine();

        }
    }
}
