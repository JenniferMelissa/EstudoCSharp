using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto do Projeto 11 - Laço de Repetição -- Calcula Poupança");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês

        /*investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);*/

        //while -> enquanto; executa condição, algo no código, laço de repetição, loop

        int mes = 1;
        
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            //mes += 1;
            //mes = mes + 1;
            mes++;
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}