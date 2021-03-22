using System;

namespace RPGAtackOnTitan
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando o personagem1 Classe HUMANO
                                            //nome //idade //level   //força //defesa //agilidade //sorte //vida
            Humano personagem1 = new Humano ("Marcos", 16, 1, new Status(20, 20, 100, 60,100));

            // Criando o titã1  Classe Titã 
                                    //nome //idade //level   //força //defesa //agilidade //sorte //vida
            Titã tita1 = new Titã("Unknow", 200, 1, new Status(1200, 150, 30, 100, 1000));

            // Criando o soldado1 Classe Soldado  
                                            //nome //idade //level   //força //defesa //agilidade //sorte //vida
            Soldado soldado1 = new Soldado("Levi", 25, 1, new Status(250, 80, 300, 90, 100));

            /// TESTES
            /// 
            Console.WriteLine("Nomes!");
            personagem1.falar();
            soldado1.falar();
            tita1.falar();
           
            Console.WriteLine("\n");

            Console.WriteLine("Ataques!");
            Console.WriteLine(personagem1.Ataque());
            Console.WriteLine(soldado1.Ataque());
            Console.WriteLine(tita1.Ataque());

            Console.WriteLine("\n");

            Console.WriteLine("Defesas!");
            Console.WriteLine(personagem1.Defesa());
            Console.WriteLine(soldado1.Defesa());
            Console.WriteLine(tita1.Defesa());

            Console.WriteLine("\n");

            Console.WriteLine("Regeneração!");
            Console.WriteLine(tita1.Regeneracao());

            Console.WriteLine("\n");

            Console.WriteLine("Recebe Dano!");
            Console.WriteLine(tita1.RecebeAtaque(personagem1.Ataque(), tita1.Defesa()));
            Console.WriteLine(tita1.RecebeAtaque(soldado1.Ataque(), tita1.Defesa()));

            Console.WriteLine("\n");

            Console.WriteLine(soldado1.RecebeAtaque(personagem1.Ataque(), soldado1.Defesa()));
            Console.WriteLine(soldado1.RecebeAtaque(tita1.Ataque(), soldado1.Defesa()));

            Console.WriteLine("\n");

            Console.WriteLine(personagem1.RecebeAtaque(soldado1.Ataque(), personagem1.Defesa()));
            Console.WriteLine(personagem1.RecebeAtaque(tita1.Ataque(), personagem1.Defesa()));

            Console.WriteLine("\n");

            Console.WriteLine(personagem1.level);
            Console.WriteLine(soldado1.level);
            Console.WriteLine(tita1.level);
        }

    }
}
