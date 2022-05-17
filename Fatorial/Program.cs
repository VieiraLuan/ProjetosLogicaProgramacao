using System;


class program
{

    static void Main(String[] args)
    {


       double i, numero, fatorial;
        Console.WriteLine("****** Programa Fatorial ******");
        Console.WriteLine("Digite o Fatorial Desejado");
        numero = Convert.ToDouble(Console.ReadLine());

        fatorial = numero;
        for (i = numero - 1; i >= 1; i--)
        {


            fatorial = fatorial * i;


        }
        Console.WriteLine("O fatorial de "+numero+" é "+fatorial);
        Console.ReadLine();
    }

}
