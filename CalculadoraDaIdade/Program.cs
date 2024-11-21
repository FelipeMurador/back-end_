using System;

namespace CalculaIdade
{
    internal class Pessoa
    {
        // Campo privado para armazenar o ano de nascimento
        private int anoNascimento;

        // Propriedade AnoNascimento
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        // Campo privado para armazenar o nome
        private string nome;

        // Propriedade Nome
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        // Método para exibir os dados da pessoa
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Ano de Nascimento: {this.AnoNascimento}");
            int idade = this.CalcularIdade();
            Console.WriteLine($"Idade: {idade}");
        }

        // Método privado para calcular a idade
        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int anoAtual = data.Year;
            int idade = anoAtual - this.AnoNascimento;
            return idade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");

            // Criando um objeto Pessoa
            Pessoa p = new Pessoa();

            // Lendo os dados de entrada
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine();

            Console.Write("Ano de Nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            // Exibindo os dados
            p.ExibirDados();

            // Esperando o usuário pressionar uma tecla para finalizar
            Console.ReadKey();
        }
    }
}
