﻿using System;
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

            int vida = _status.Vida;
            int danoRecebido = defesa - dano;
            int resultado = vida - danoRecebido;

            if (danoRecebido > 0)
            {
                Console.WriteLine("Dano = {0}, sua defesa {1}, dano recebido {2} --- Você defendeu o ataque, sua vida atual: {3}", dano, defesa, danoRecebido, _status.Vida);
                resultado = _status.Vida;
            }
            else if (danoRecebido < 0)
            {
                Console.WriteLine("DANO RECEBIDO = {0} --- Voce morreu! sua vida atual: {1} Sua defesa = {2}", danoRecebido, _status.Vida, defesa);
                _status.Vida = _status.Vida - danoRecebido;
            }

            return vida;
        }
        

    }
}
