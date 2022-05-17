using System;


class program
{

    static void Main(String[] args)
    {
        int[] geral= new int[15];
        int[] par = new int[15];
        int[] impar = new int[15];

        Console.WriteLine("Digite 15 Valores: ");
       
        for (int i = 0; i < geral.Length; i++)
        {
            Console.WriteLine("Digite um numero: ");
            geral[i] = Convert.ToInt32(Console.ReadLine());

        } //Entrada

        for (int i = 0; i < par.Length; i++)
        {
            if (geral[i] % 2 == 0)
            {
                par[i] = geral[i];
            }
            else {
                impar[i] = geral[i];
            }
        } //Processamento

        Console.WriteLine("Veja abaixo os números que foram digitados: ");
        for (int i = 0; i < geral.Length; i++)
        {

           
            Console.WriteLine(geral[i] + "; ");

        } //Saida Geral

        Console.WriteLine("Veja abaixo os números impares que foram digitados: ");

        for (int i = 0; i < impar.Length; i++)
        {
            if (impar[i] != 0)
            {



                Console.WriteLine(impar[i] + "; ");
            }

        } // Saida Impares


        Console.WriteLine("Veja abaixo os números pares que foram digitados: ");

        for (int i = 0; i < par.Length; i++)
        {
            if (par[i] != 0)
            {

                Console.WriteLine(par[i] + "; ");
            }


        }// Saida Pares 



        Console.WriteLine("Obrigado!!!"); // Fim





    }
}