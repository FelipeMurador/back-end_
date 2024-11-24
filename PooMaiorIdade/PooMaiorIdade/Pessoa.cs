using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMaiorIdade
{
	public class Pessoa
	{

		//construtores 
		public Pessoa()
		{
			this.Nome = "";

			this.idade = 0;
		}
		public Pessoa(String nome, int idade)
		{
			this.Nome   = nome;
			this.idade = idade;
		}
		//propriedades************** nome **** idade

		public string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private int idade;
		public int Idade
		{
			get { return idade; }
			set
			{
				if (value >= 0)
				{
					idade = value;
				}
				else
				{
					this.idade = 0;
				}

			}
		}
				//Métodos ********exibirdados()
				public void ExibirDados()
				{
					Console.WriteLine("Nome:" + this.Nome);
					Console.WriteLine("Idade:" + this.idade);
				}
			}
		
}
