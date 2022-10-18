using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto 10 - Escopo");
     
        //compara tipo e o valor -> ===
        //compara apenas o valor -> ==
        //recebe -> =

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado!";
        }
        else
        {
            textoAdicional = "João não está acompanhado!";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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


