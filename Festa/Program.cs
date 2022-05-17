using System;


class program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Bem vindo a Festa!!! ");

        Console.WriteLine("Qual a sua idade? ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Está acompanhado? ");
        Boolean acompanhado = Convert.ToBoolean(Console.ReadLine());

        if (idade >= 18 || acompanhado == true)
        {

            Console.WriteLine("Pode entrar meu jovem gafanhoto");

        }
        else { 
            
            Console.WriteLine("Cai fora");
        
        
        }
    }

}