using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDeEstimação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlcachorro = 0, tlGato = 0, tlPeixe = 0;

            //primeiro animal
            Console.WriteLine("Controle de animais");
            Console.WriteLine("Informe o nome do 1º animal: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo 1º animal:(Cachorro, Gato ou Peixe:");
            a1.Tipo= Console.ReadLine();


            if (a1.Tipo == "Cachorro") tlcachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;

            //segundo animal 
            Console.WriteLine("Informe o nome do 2° animal:");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo 2 animal:(Cachorro, Gato ou Peixe:");
            a2.Tipo = Console.ReadLine();


            if (a2.Tipo == "Cachorro") tlcachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;

            //Terceiro animal 
            Console.WriteLine("Informe o nome do 3° animal:");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo 3 animal:(Cachorro, Gato ou Peixe:");
            a3.Tipo = Console.ReadLine();


            if (a3.Tipo == "Cachorro") tlcachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;

            //Quarto Animal
            Console.WriteLine("Informe o nome do 4° animal:");
            a4.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo 4 animal:(Cachorro, Gato ou Peixe:");
            a4.Tipo = Console.ReadLine();


            if (a4.Tipo == "Cachorro") tlcachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;

            //Resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorro: " + tlcachorro+"\nGatos:" +tlGato+ "\n Peixes " +tlPeixe);
            Console.ReadLine(); 
        }
    }
}
