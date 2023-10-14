using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LarguraAlturaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre com os dados do retangulo");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}
