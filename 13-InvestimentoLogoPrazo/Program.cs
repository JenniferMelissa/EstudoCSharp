using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o porjeto 13 - Investindo a Longo Prazo!");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        //declara a variavel com seu valor, condição e contador(se ele sera auto-increment)
        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
