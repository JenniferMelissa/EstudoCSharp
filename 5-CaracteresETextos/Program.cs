using System;
class Programa
{
    static void Main(string[] args)
    {

        //podemos ter uma string vazia, no char NÂO
        Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

        //Armazenar caracteres, um caracter apenas, ex: %,@,a
        //Usa aspas simples '';
        //O computador entende o caracter como número
        //char armazena ate 16 bits, numeros sao 32 bits
        char letra = 'a';
        Console.WriteLine(letra);

        //convertendo o 65 para a variavel do tipo char
        //podemos fazer contas com char tbm
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        Console.WriteLine("Tecle entrer para fechar...");
        Console.ReadLine();
    }
}
