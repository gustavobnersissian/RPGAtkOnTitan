using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Status
    {
        public int Força { get; set; }
        public int Defesa { get; set; }
        public int Agilidade { get; set; }
        public int Sorte { get; set; }
        public int Vida { get; set; }
        public int Vigor { get; set; }

        public Status(int força, int defesa, int agilidade, int sorte, int vida, int vigor)
        {
            this.Força = força;
            this.Defesa = defesa;
            this.Agilidade = agilidade;
            this.Sorte = sorte;
            this.Vida = vida;
            this.Vigor = vigor;
        }

        public void falaVida()
        {
            Console.WriteLine("Minha vida é de {0}", this.Vida);
        }




    }
}
