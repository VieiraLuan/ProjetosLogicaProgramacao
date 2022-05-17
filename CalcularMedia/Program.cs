using System;


class program {
    static void Main(string[] args)
    {

        double n1, n2;
        double frequencia;



        Console.WriteLine("Digite a primeira nota: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        //refatorar 

        Console.WriteLine("qual a quantidade de aulas? ");
        int quantidadeAulas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("qual a quantidade de faltas? ");
        int quantidadeFaltas = Convert.ToInt32(Console.ReadLine());

        frequencia = quantidadeAulas / (quantidadeAulas - quantidadeFaltas);


        double media = (n1+n2)/2;


        if (media >= 70 && frequencia *100 >= 75) {


            Console.WriteLine("A média do Aluno foi " + media + " e a frequencia foi " + frequencia*100 + " ,então ele está aprovado");

        }
        else
        {

            Console.WriteLine("A média do Aluno foi " + media +" e a frequencia foi " + frequencia*100 + " ,então ele está reprovado");
        }


    }

}