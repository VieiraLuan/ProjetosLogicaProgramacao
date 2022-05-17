using System;
class program
{
    static void Main(String[] args)
    {

        double[,] teste = new double[5, 5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o Codigo do " + (i + 1) + "º Aluno: ");
            teste[i, 0] = Convert.ToDouble(Console.ReadLine());

            for (int j = 0; j < 5; j++)
            {                           
                Console.WriteLine("Digite a " + (j) + "º nota do Aluno: ");
                teste[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Veja o Codigo do " + (i + 1) + "º Aluno: "+teste[i, 0]);
           

            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine("veja a " + (j) + "º nota do Aluno: "+ teste[i, j]);
            
            }
        }









    }
}