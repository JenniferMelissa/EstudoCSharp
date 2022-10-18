using System;

class Programa
{
    static void Main(string[] args)
    {
        

        for(int contador = 0; contador <= 10; contador++)
        {
            Console.WriteLine(contador);
        }

        Console.WriteLine();

        //OUTRO EXERCÍCIO

        for (int i = 1; i < 100; i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        //ou

        for(int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}