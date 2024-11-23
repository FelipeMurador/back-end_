using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDeEstimação
{
    internal class Animal
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set{
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    tipo = value;                   
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }
    }

}