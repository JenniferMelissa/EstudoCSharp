using System;
class Programa
{
    static void Main(string[] args)
    {

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);


        //int armazena 32 bits e o long armazena 64 bits
        long x;
        x = 2000000000000000;
        Console.WriteLine(x);

        //short é utilizado para números menores, armazena até 16 bits
        short y;
        y = 15000;
        Console.WriteLine(y);

        //float tem precisão de 6 casas decimais; o double tem precisao de 10 casa decimais(maior precisão)
        //Se você tiver um número decimal e fizer uma operação com ele da qual necessite que o resultado seja preciso, 
        //é recomendável utilizar o double. Se você não precisa disso, se não faz questão de perder alguns números após a vírgula,
        //utilize o float, que reserva menos memória.
        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}