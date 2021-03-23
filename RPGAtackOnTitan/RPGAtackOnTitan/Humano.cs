using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Humano : Heroi
    {
        //public Status status;

        public Humano(string nome, int idade, int level, Status status)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Level = level;
            this._status = status;
        }
        
        
        public int Ataque()
        {
            int ataque;
            int sorteio;

            System.Random random = new System.Random();
                                            //sorte = 60
            sorteio = (1+random.Next(0, _status.Sorte));

            ataque = (_status.Força + _status.Agilidade) * sorteio;

            if (_status.Vigor == 0)
            {
                return ataque = 0;
            }
            // Se o ataque for bem sucedido, ganha um quantidade mínima de xp
            if (ataque > 0)
            {
                this.Level += 1;
                _status.Vigor = _status.Vigor - 60;
            }

            return ataque/100;           
        }

        public int Defesa()
        {

            int defesa;
            int sorteio;

            System.Random random = new System.Random();
            
            sorteio = (1 + random.Next(0, _status.Sorte));

            defesa = (_status.Defesa + _status.Agilidade) * sorteio;

            return defesa/100;
        }

        public int RecebeAtaque(int dano, int defesa)
        {                              
            
            _status.Vida = defesa - dano;
            int vida  = _status.Vida;

            if (vida > 0)
            {
                Console.WriteLine("DANO = {0} --- Você defendeu o ataque, sua vida atual: {1} {2}", dano ,_status.Vida,defesa);
                vida = _status.Vida;
            }
            else if(vida < 0)
                Console.WriteLine("DANO = {0} --- Voce morreu! sua vida atual: {1} {2}",dano, _status.Vida, defesa);

            return vida;
        }
        

    }
}
