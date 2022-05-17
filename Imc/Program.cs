using System;


class program
{
 
    static void Main(String[] args)
    {

        double altura;
        double peso;
        double resultado;
        string nome;

        Console.WriteLine("Qual o seu Nome? ");
        nome= Console.ReadLine();

        Console.WriteLine("Qual seu peso? ");
        peso = Convert.ToDouble( Console.ReadLine());

        Console.WriteLine("Qual sua altura? ");
        altura = Convert.ToDouble(Console.ReadLine());

        resultado = ( peso / (altura * altura));

        Console.WriteLine(nome+" o seu Imc é "+resultado + "\n");
        
        if (resultado <= 18.5)
        {
            Console.WriteLine("abaixo do peso");

        }

        if (resultado >= 18.6 && resultado <=24.90 )
        {
            Console.WriteLine("peso ideal");

        }
        if (resultado >= 25.00 && resultado <= 29.90)
        {
            Console.WriteLine("levemente acima do peso");

        }
        if(resultado > 29.90)
        {
            Console.WriteLine("Vc está acima do peso! ");
        }
        




    }


}