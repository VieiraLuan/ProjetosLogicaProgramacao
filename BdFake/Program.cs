using System;


class program
{

    static void Main(String[] args)
    {

        String[,] bd = new string[5, 5];

        Console.WriteLine("----------------------");
        Console.WriteLine("Cadastro de Contatos");
        Console.WriteLine("----------------------");
        int posicaoInicial = 0;
        String teste = "";

        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine("Digite os dados do " + (i + 1) + "º contato: ");

            Console.Write("CPF: ");
            bd[i, posicaoInicial + 1] = Convert.ToString(Console.ReadLine());


            Console.Write("NOME: ");
            bd[i, posicaoInicial + 2] = Convert.ToString(Console.ReadLine());

            Console.Write("TELEFONE: ");
            bd[i, posicaoInicial + 3] = Convert.ToString(Console.ReadLine());

            Console.Write("EMAIL: ");
            bd[i, posicaoInicial + 4] = Convert.ToString(Console.ReadLine());



            if (i <= 4)
            {
                Console.WriteLine("Deseja incluir mais pessoas ao cadastro? 'S' para SIM e 'N' NÃO");
                teste = Console.ReadLine().ToUpper();
            }

            if (teste == "N")
            {
                Console.WriteLine("Fim do Cadastro");
                i = 5;

            }


        } // Cadastro

        posicaoInicial = 0;

        for (int j = 0; j < 5; j++) // Exibição 
        {
            Console.WriteLine("Veja os dados do " + (j + 1) + "º contato: ");

            Console.Write("CPF:" + bd[j, posicaoInicial + 1]);

            Console.Write("NOME:" + bd[j, posicaoInicial + 2]);

            Console.Write("TELEFONE:" + bd[j, posicaoInicial + 3]);

            Console.WriteLine("EMAIL:" + bd[j, posicaoInicial + 4]);


            if (String.IsNullOrEmpty(bd[j + 1, posicaoInicial+1]) && j < 5 && posicaoInicial < 5)
            {

                j = 5;

                Console.WriteLine("Fim dos Contatos...");
            }

        }


    }
}
