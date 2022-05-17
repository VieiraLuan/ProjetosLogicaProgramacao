using System;


class program
{
    

    static void Main(String[] args)
    {

        Console.WriteLine("Digite a quantidade de vendedores: ");
        int nVendedores = Convert.ToInt32(Console.ReadLine()); // motando os vetores
        double[] vendas = new double[nVendedores]; // declarando o vetor

        for (int i = 0; i < vendas.Length; i++) //For para carregar o vetor
        {
            Console.WriteLine("Digite o valor das vendas do vendedor {0}: ", i+1);
            vendas[i] = Convert.ToDouble(Console.ReadLine()); // alimentando indice por indice

        }
        double totalVendas=0;

        for (int j = 0; j < vendas.Length; j++) // for para somar as vendas //.length é o tamanho do vetor declarado em cima que é nVendedores
        {
            totalVendas += vendas[j]; // somando as vendas

        }

        Console.WriteLine("O total das vendas é {0}: ", totalVendas); // exibindo o total das vendas

    }
}
