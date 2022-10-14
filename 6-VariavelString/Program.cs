using System;
class Programa
{
    static void Main(string[] args)
    {

        //usamos string para armazenar letras, textos, nomes, cadeia de caracteres
        string primeiraFrase = "Alura - Cursos de Tecnologia";
        Console.WriteLine(primeiraFrase + 2022);

        //podemos ter uma string vazia, no char NÂO
        string vazia = "";
        Console.WriteLine(vazia);

        //Não separa itens por linha, mesmo colocando cada item numa linha diferente
        string cursos = "Cursos Disponíveis: - GO - C# - Python _ Java";
        Console.WriteLine(cursos);
        //OU
        //Separar item por linhas
        string cursos1 = @"Cursos Disponíveis:
        - Go
        - C#
        - Python
        - Java";
        Console.WriteLine(cursos1);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

