using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Soldado : Heroi
    {
        public Soldado(string nome, int idade, int level, Status status)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = level;
            this.status = status;
        }

        public int Ataque()
        {
            int ataque;
            int sorteio;

            System.Random random = new System.Random();
            //sorte = 60
            sorteio = (1 + random.Next(0, status.sorte));

            ataque = (status.força + status.agilidade) * sorteio;

            // Se o ataque for bem sucedido, ganha um quantidade mínima de xp
            if (ataque > 0)
            {
                this.level += 1;
            }

            return ataque / 100;
        }

        public int Defesa()
        {

            int defesa;
            int sorteio;

            System.Random random = new System.Random();

            sorteio = (1 + random.Next(0, status.sorte));

            defesa = (status.defesa + status.agilidade) * sorteio;

            return defesa / 100;
        }

        public int RecebeAtaque(int dano, int defesa)
        {

            status.vida = defesa - dano;
            int vida = status.vida;

            if (vida > 0)
            {
                Console.WriteLine("DANO = {0} --- Você defendeu o ataque, sua vida atual: {1} {2}", dano, status.vida, defesa);
                vida = status.vida;
            }
            else if (vida < 0)
                Console.WriteLine("DANO = {0} --- Voce morreu! sua vida atual: {1} {2}", dano, status.vida, defesa);

            return vida;
        }


    }
}

