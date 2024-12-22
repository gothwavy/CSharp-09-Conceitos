using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_This
{
    internal class Pessoa
    {
        // Atributo
        private string nome = "Tatiana";

        // Construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }

    }
}
