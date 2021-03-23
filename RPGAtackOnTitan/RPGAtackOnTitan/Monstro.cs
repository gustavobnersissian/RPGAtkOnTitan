using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Monstro
    {
        public int Level { get; set; }
        public Status _status { get; set; }
        public string Nome { get; set; }

        public void falar()
        {
            Console.WriteLine("O meu nome é {0}!", this.Nome);
        }

        public void falaVida()
        {
            Console.WriteLine("Minha vida é de {0}", _status.Vida);
        }
        public void meuStatus()
        {
            Console.WriteLine("///// MEU STATUS /////");
            Console.WriteLine("Força = {0}", this._status.Força);
            Console.WriteLine("Defesa = {0}", this._status.Defesa);
            Console.WriteLine("Agilidade = {0}", this._status.Agilidade);
            Console.WriteLine("Sorte = {0}", this._status.Sorte);
            Console.WriteLine("Vida = {0}", this._status.Vida);
            Console.WriteLine("Vigor = {0}", this._status.Vigor);
            Console.WriteLine("//////////////////////");
        }
    }
}
