using System;
class Programa
{
    static void Main(string[] args)
    {

        double salario;
        salario = 3000.10;
        salario = 3000;

        double idade;
        idade = 7 / 5;
        //idade = 7.0 / 5; Desta forma ele conta o numero depois da vírgula


        Console.WriteLine(idade);
        Console.WriteLine(salario);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

        //Tudo que vem depois da vírgula ele não considera, apenas o que vem antes
        //Ao fazer alguma conta e algum desses números é flutuante(float), o resultado contem número com vírgula
        //Fazendo conta apenas com números inteiros, o rultado será um número inteiro
    }
}
