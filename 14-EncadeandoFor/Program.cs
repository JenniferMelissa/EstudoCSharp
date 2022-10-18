using System;

class Programa
{
    static void Main(string[] args)
    {
        //COM BREAK

        Console.WriteLine("Executando o Projeto 14 - Encadeando For");

        for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for(int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                //apenas escreve
                Console.Write("*");
                if(contadorColunas >= contadorLinhas)
                {
                    //para o programa quando a condiçaõ for respeitada
                    break;
                }
            }
            //escreve e pula linha
            Console.WriteLine();
        }





        //SEM BREAK

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                //apenas escreve
                Console.Write("*");
            }
            //escreve e pula linha
            Console.WriteLine();
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }

    






        
}



    

