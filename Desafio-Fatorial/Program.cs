﻿//Agora crie uma nova classe, escreva um for que inicie uma variável n (número atual)
//como 1 e fatorial (resultado total) como 1.
//Faça seu laço entre 1 a 10 e calcule o resultado!

using System;

class Programa
{
    static void Main(string[] args)
    {

        int fatorial = 1;

        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
    }
}