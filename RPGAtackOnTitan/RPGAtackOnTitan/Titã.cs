using System;
using System.Collections.Generic;
using System.Text;

namespace RPGAtackOnTitan
{
    class Titã : Heroi
    {

        public Titã(string nome, int idade, int level, Status status)
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

            if(status.vigor == 0)
            {
                return ataque = 0;
            }

            // Se o ataque for bem sucedido, ganha um quantidade mínima de xp
            if (ataque > 0)
            {
                this.level += 1;
                status.vigor = status.vigor - 70;

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
            int vida = status.vida;
            int danoRecebido = defesa - dano;
            
            int resultado = vida - danoRecebido;

            if (danoRecebido > 0)
            {
                Console.WriteLine("Dano = {0}, sua defesa {1}, dano recebido {2} --- Você defendeu o ataque, sua vida atual: {3}", dano, defesa, danoRecebido, status.vida);
                resultado = status.vida;
            }
            else if (danoRecebido < 0)
                Console.WriteLine("DANO RECEBIDO = {0} --- Voce morreu! sua vida atual: {1} Sua defesa = {2}", danoRecebido, status.vida, defesa);

            return vida;
        }

        public int Regeneracao()
        {
            int vida = status.vida;

            if(vida < 800)
            {
                Console.WriteLine("Vida regenerada!");
                status.vida += 100;
                status.vigor -= 100;
            }
            else
                Console.WriteLine("Nao foi possível!");



            return vida;
        }
        
        // Sobrepõe a função falar() da classe Héroi
        public void falar()
        {
            Console.WriteLine("UUHHHAAAAHHHH ~ Gritos assusturadores de um Titã");
        }
        
    }
}
