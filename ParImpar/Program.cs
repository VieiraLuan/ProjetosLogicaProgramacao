using System;


class program
{

    static void Main(String[] args)
    {

        Console.WriteLine("Digite um valor: ");
        int i = Convert.ToInt32(Console.ReadLine());
        

        while ( i !=0) {

            if (i % 2 == 0) {
                Console.WriteLine(i + " é par");
            }
            else
            {

                Console.WriteLine(i + " é impar");
            }
            i--;
            
        
        }

        Console.WriteLine("Obrigado!!!");
    
    
    
    
    }
}