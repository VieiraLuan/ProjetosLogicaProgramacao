using System;


class program
{

    static void Main(String[] args)
    {

        Console.WriteLine("Projeto Tabuada");


        int tabuada, resultado;
        Boolean ativar = true, lup = true, ativardois =false;
        string letra;

        while (lup == true)
        {

            Console.WriteLine("Qual a tabuada desejada?");
            tabuada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veja a tabuada abaixo: ");

            for (int i = 0; i <= 10; i++)
            {
                resultado = tabuada * i;
                /* Console.WriteLine(tabuada+" X "+i+" = "+resultado); */ //Forma Simples
                Console.WriteLine("{0} X {1} = {2}", tabuada, i, resultado); //Forma Elegante

            }

            

            while (ativar == true)
            {
                Console.WriteLine("Deseja outra tabuada? \n Digite, 'S' para SIM ou 'N' para NÃO");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
                letra = Console.ReadLine().ToUpper();
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.


                switch (letra)
                {
                    case "N":
                        lup = false;
                        ativar = false;
                        Console.WriteLine("Acabou o programa! ");

                        break;
                    case  "S":
                        
                        ativar = false;
                         ativardois = true;

                        break;

                    default:
                        Console.WriteLine("Digite apenas 'S' ou 'N'");
                        break;

                }
            }
            if (ativardois == true)
            {
                lup = true;
            }

    
            
        }

    }



}

