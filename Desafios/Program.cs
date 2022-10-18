using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//João está criando uma aplicação para calcular o IR a partir do salário.
//Ele olhou na tabela de IRPF e implementou as regras para 15% e 22.5%:

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario < 2600.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }
        if (salario < 3750.0)
        {
            Console.WriteLine("A sua aliquota é de 22,5%");
            Console.WriteLine("Você pode deduzir até R$ 636");
        }
    }
}

//Dessa vez, João fez uma implementação para calcular o salário de um funcionário
//em caso de promoção.
//Ele fez a seguinte implementação:


class Programa1
{
    static void Main(string[] args)
    {

        bool foiPromovido = true;

        if (foiPromovido)
        {
            double salario = 4200.0;
        }
        else
        {
            double salario = 3800.0;
        }
    }
}

//O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota.
//Ele descobriu no site da receita o seguinte:
/*De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.
Para começar, o João escreveu o seguinte esboço:*/

class Programa2
{
    static void Main(string[] args)
    {
        // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
        // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
        // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

        double salario = 3800.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("A sua aliquota é de 7%");
            Console.WriteLine("Você pode deduzir até R$ 142");
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }
        else if (salario >= 3751.01 && salario <= 4664.0)
        {
            Console.WriteLine("A sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir até R$ 636");
        }
    }
}

//Temos uma variável mes e precisamos testar o seu
//número e imprimir o seu mês correspondente.
class Programa3
{
    static void Main(String[] args)
    {
        int mes = 13;

        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês é Janeiro");
                break;
            case 2:
                Console.WriteLine("O mês é Fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês é Março");
                break;
            case 4:
                Console.WriteLine("O mês é Abril");
                break;
            case 5:
                Console.WriteLine("O mês é Maio");
                break;
            case 6:
                Console.WriteLine("O mês é Junho");
                break;
            case 7:
                Console.WriteLine("O mês é Julho");
                break;
            case 8:
                Console.WriteLine("O mês é Agosto");
                break;
            case 9:
                Console.WriteLine("O mês é Setembro");
                break;
            case 10:
                Console.WriteLine("O mês é Outubro");
                break;
            case 11:
                Console.WriteLine("O mês é Novembro");
                break;
            case 12:
                Console.WriteLine("O mês é Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
        Console.ReadLine();
    }
}
