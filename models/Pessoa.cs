using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            console.WriteLine($"Olá, meu nome é {Nome}, e tenho {idade} anos;")
        }
    }
}