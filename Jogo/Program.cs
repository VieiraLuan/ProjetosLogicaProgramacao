using System;


class program
{
    static void Main(String[] args)
    {

        Console.WriteLine("***** Bem vindo ao Jogo JoquemPO!!! *****");
        Console.WriteLine("PEDRA PAPEL E TESOURA");

        Boolean iniciar = false;
        int escolhaUsuario, escolhaComputador;

        while (iniciar == false)
        {

            Console.WriteLine("Escolha: \n 1:Pedra \n 2:Papel \n 3:Tesoura");
            escolhaUsuario = Convert.ToInt32(Console.ReadLine());

            if (escolhaUsuario == 1)
            {

                Console.WriteLine("Você escolheu Pedra! ");
                iniciar = true;

            }
            else if (escolhaUsuario == 2)
            {
                Console.WriteLine("Você escolheu Papel! ");
                iniciar = true;
            }
            else if (escolhaUsuario == 3)
            {

                Console.WriteLine("Você escolheu Tesoura! ");
                iniciar = true;
            }
            else
            {
                Console.WriteLine("Escolha um número de 1 a 3");


            }

            while (iniciar == true)
            {
                Random r = new Random();
                escolhaComputador = r.Next(1, 4);

                if (escolhaUsuario == escolhaComputador)
                {
                    Console.WriteLine("Aconteceu um empate!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 1 && escolhaComputador == 2)
                {
                    Console.WriteLine("O computador ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 2 && escolhaComputador == 1)
                {
                    Console.WriteLine("Vc ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 2 && escolhaComputador == 3)
                {
                    Console.WriteLine("O computador ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 3 && escolhaComputador == 2)
                {
                    Console.WriteLine("Vc ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 3 && escolhaComputador == 1)
                {

                    Console.WriteLine("O computador ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;

                }
                else if (escolhaUsuario == 3 && escolhaComputador == 2)
                {
                    Console.WriteLine("Vc ganhou!!!");
                    Console.WriteLine("Escolha Computador: " + escolhaComputador + " X " + "escolha Usuario: " + escolhaUsuario);
                    iniciar = false;
                }

            }

            iniciar = true;


            // jogar novamente

            Console.WriteLine("Quer jogar mais?");
        }








    }
}