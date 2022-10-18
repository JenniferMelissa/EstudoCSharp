using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto 9 - Projeto Condicionais Booleano!");
        //Booleano - armazena apenas 2 valores: true ou false
        // || -> OR
        // && -> AND
        //bool armazena o valor


        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

