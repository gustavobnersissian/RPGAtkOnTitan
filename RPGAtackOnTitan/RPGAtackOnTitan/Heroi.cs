using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Heroi 
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Level { get; set; }
        public Status _status { get; set; }

        public void falar()
        {
            Console.WriteLine("O meu nome é {0}!", this.Nome);
        }
        public void falaVida()
        {
            Console.WriteLine("Minha vida é de {0}", _status.Vida);
        }

        
    }
}
