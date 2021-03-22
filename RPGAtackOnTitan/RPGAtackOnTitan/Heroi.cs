using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Heroi 
    {

        public string nome; 
        public int idade;
        public int level;
        public Status status;

        public void falar()
        {
            Console.WriteLine("O meu nome é {0}!", this.nome);
        }
    }
}
