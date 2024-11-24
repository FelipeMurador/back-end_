using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determine qual pessoa é a mais velha");
           //Leitura de dados da 1 pessoa
            Console.Write("Nome da 1° pessoa");
            p1 =new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1° Pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 2 pessoa
            Console.Write("Nome da 2° pessoa");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2° Pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 3 pessoa
            Console.Write("Nome da 3° pessoa");
            p3 = new Pessoa();
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 3° Pessoa: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());
            //Lógica
            if((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mai velha é:");
                p1.ExibirDados();   
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas pessoas tem a mesma idade ");
                    }
                }
            }
            Console.ReadKey();    
        }

    }
}
