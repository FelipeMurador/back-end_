using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
           Console.WriteLine("Calcula a area de um retangulo");
            Console.WriteLine("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a base /largura: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibeDados();
            Console.ReadKey();
        }
    }
}
