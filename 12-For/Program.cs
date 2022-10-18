using System;

class Programa
{
    static void Main(string[] args)
    {
        //rendimento de 0.5% (0.005) ao mês
    
        Console.WriteLine("Executanto do Projeto 11 - Laço de Repetição -- Calcula Poupança");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes = mes + 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        } 


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}