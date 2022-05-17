using System;
class program
{
    static void Main(String[] args)
    {
        int[] a = new int[20];
        int[] b = new int[20];
        int[] c = new int[20];

        Console.WriteLine("Digite os Numeros da Matriz A: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Digite um numero: ");
            a[i] = Convert.ToInt32(Console.ReadLine());

        } //Entrada

        Console.WriteLine("Digite os Numeros da Matriz B: ");
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine("Digite um numero: ");
            b[i] = Convert.ToInt32(Console.ReadLine());

        } //Entrada

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = a[i] * b[i];
        } //Processamento

        Console.WriteLine("Veja abaixo o resultado das Multiplicações: ");
        for (int i = 0; i < c.Length; i++)
        {

            Console.WriteLine("{0} x {1} = {2}", a[i], b[i], c[i]);



        } //Saida Geral

        Console.WriteLine("Obrigado!!!"); // Fim

    }
}