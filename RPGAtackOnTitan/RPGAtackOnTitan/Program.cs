using System;

namespace RPGAtackOnTitan
 {
   class Program
    {
        //teste commit 2
        static void Main(string[] args)
        {

            // Criando o personagem1 Classe HUMANO
                                            //nome //idade //level   //força //defesa //agilidade //sorte //vida //vigor
            Humano personagem1 = new Humano ("Marcos", 16, 1, new Status(20, 20, 100, 60, 100, 100));

            // Criando o titã1  Classe Titã 
                                    //nome //idade //level   //força //defesa //agilidade //sorte //vida
            Titã tita1 = new Titã( 1, new Status(1200, 150, 30, 100, 100, 400));

            // Criando o soldado1 Classe Soldado  
                                            //nome //idade //level   //força //defesa //agilidade //sorte //vida
            Soldado soldado1 = new Soldado("Levi", 25, 1, new Status(250, 10, 300, 90, 100, 200));

            // Criando o soldado1 Classe Soldado  
                                            //nome //idade //level   //força //defesa //agilidade //sorte //vida//vigor
            Soldado soldado2 = new Soldado("Joao",22,1, new Status(250, 80, 300, 90, 100, 200));
            // Criando o titã1  Classe Titã 
                                               //level//força //defesa //agilidade //sorte //vida//vigor
            Titã tita2 = new Titã(1, new Status(1200, 150, 30, 100, 1000, 500));
                                                                //level//força //defesa //agilidade //sorte //vida//vigor
            TitanAnormal tita3 = new TitanAnormal(1, new Status(1200, 150, 30, 100, 1000, 500));
            


            /// TESTES
            
            Console.WriteLine("Nomes!");
            personagem1.falar();
            personagem1.falaVida(); 
            soldado1.falar();
            soldado1.falaVida();
            
           
            Console.WriteLine("\n");

            Console.WriteLine("Ataques!");
            Console.WriteLine("O dano do {0} é de {1} no primeiro round!" , personagem1.Nome, personagem1.Ataque());
            Console.WriteLine("O dano do {0} é de {1} no primeiro round!",soldado1.Nome ,soldado1.Ataque());
            Console.WriteLine("O dano do Titan eh {0} mas ele não ataca nessa Rodada",tita1.Ataque());
            Console.WriteLine("O dano do Titan eh {0} mas ele não ataca nessa Rodada", tita2.Ataque());



            Console.WriteLine("\n");

            Console.WriteLine("Defesas!");
            Console.WriteLine("A defesa de {0} é de {1}",personagem1.Nome, personagem1.Defesa());
            Console.WriteLine("A defesa de {0} é de {1}",soldado1.Nome, soldado1.Defesa());
            Console.WriteLine("A defesa do Titan é de {0}",tita1.Defesa());
            Console.WriteLine("A defesa do Titan anormal é de {0}", tita2.Defesa());
           

            Console.WriteLine("\n");           
           
            Console.WriteLine("\n");

            Console.WriteLine("Recebe Dano!");
            ///Console.WriteLine(tita1.RecebeAtaque(personagem1.Ataque(), tita1.Defesa()));
            Console.WriteLine(tita1.RecebeAtaque(soldado1.Ataque(), tita1.Defesa()));


            Console.WriteLine("\n");


            Console.WriteLine(tita1._status.Vida);
            //Console.WriteLine(soldado1.RecebeAtaque(personagem1.Ataque(), soldado1.Defesa()));
            //Console.WriteLine(soldado1.RecebeAtaque(tita1.Ataque(), soldado1.Defesa()));

            Console.WriteLine("Recebe Dano!");
            Console.WriteLine(tita1.RecebeAtaque(personagem1.Ataque(), tita2.Defesa()));
            Console.WriteLine(tita1.RecebeAtaque(soldado1.Ataque(), tita2.Defesa()));

           

 
            //Console.WriteLine(personagem1.RecebeAtaque(soldado1.Ataque(), personagem1.Defesa()));
            //Console.WriteLine(personagem1.RecebeAtaque(tita1.Ataque(), personagem1.Defesa()));

            Console.WriteLine("\n");

            //Console.WriteLine(personagem1.level);
            //Console.WriteLine(soldado1.level);
            //Console.WriteLine(tita1.level);


        

            Console.WriteLine("\n");

            Console.WriteLine(personagem1.Level);
            Console.WriteLine(soldado1.Level);
            Console.WriteLine(tita1.Level);

            Console.WriteLine(soldado1._status.Força);
        }

    }
}
    
 