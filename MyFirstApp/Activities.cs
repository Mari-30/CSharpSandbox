﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;

namespace MyFirstApp;

internal static class Activities
{
    public static void Activity01()
    {
        int? integer = ConsoleExtensions.ReadInt(true, "Digite sua idade:");
        char? caractere = ConsoleExtensions.ReadChar(true, "Digite seu sexo:");
        double? @decimal = ConsoleExtensions.ReadDouble(true, "Digite sua altura:");

        string[] vet = ConsoleExtensions.ReadString().Split(' ') ?? [];

        try
        {
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("Valores digitados:");
            Console.WriteLine($"Inteiro: {integer}");
            Console.WriteLine($"Caraceter: {caractere}");
            Console.WriteLine($"Decimal: {@decimal}");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
        }
        catch(Exception)
        {
            Console.WriteLine("Um erro inesperado ocorreu");
        }
    }
    public static void Activity02() {

        string frase = ConsoleExtensions.ReadString();
        string x = ConsoleExtensions.ReadString();
        string y = ConsoleExtensions.ReadString();
        string z = ConsoleExtensions.ReadString();

        string[] v = ConsoleExtensions.ReadString().Split(' ') ?? [];
        
        if(v.Length >= 3)
        {
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    public static void Activity03() {

        Console.WriteLine("Digite seu nome");
        string[] nome = ConsoleExtensions.ReadString().Split(' ') ?? [];
        int? quartos = ConsoleExtensions.ReadInt(true, "Quantos quartos tem na sua casa?");
        double? preco = ConsoleExtensions.ReadDouble(true, "Entre com o preço de um produto");
        Console.WriteLine("Entre com seu ultimo nome, idade e altura");
        string[] vet = ConsoleExtensions.ReadString().Split(" ") ?? [];
        string nomeCompleto = string.Join(' ', nome);

        string sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);

        Console.WriteLine(nomeCompleto);
        Console.WriteLine($"Quartos: {quartos}");
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine(altura);

    }

    public static void Activity04() {

        double? area, preco;

        double? largura = ConsoleExtensions.ReadDouble(true, "Insira a largura do terreno: ");
        double? comprimento = ConsoleExtensions.ReadDouble(true, "Insira o comprimento: ");
        double? valor = ConsoleExtensions.ReadDouble(true, "Insira o valor da area: ");

        area = largura * comprimento;
        preco = area * valor;

        Console.WriteLine("A area do terreno é: " + area);
        Console.WriteLine("O preço do terreno é: " + preco);


    }

    public static void Activity05()
    {

        double? raio = ConsoleExtensions.ReadDouble(true, "insira o valor do raio: ");

        double n = 3.14159;

        double? area = n * (raio * raio);

        Console.WriteLine($"O valor da area é {area}");

    }

    public static void Activity06()
    {
        int A, B, soma;

        Console.WriteLine("Digite um valor para A: ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para B: ");
        B = int.Parse(Console.ReadLine());

        soma = A + B;

        Console.WriteLine($"SOMA={soma}");

    }

    public static void Activity07() {

        //Exercicio 1004 URI
        
        int x, y, PROD;

        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());

        Console.Write("y = ");
        y = int.Parse(Console.ReadLine());

        PROD = x * y;

        Console.WriteLine($"PROD = {PROD}");
    
    }

    public static void Activity08() {

        //Exercicio 1007 URI

        string[] vet = ConsoleExtensions.ReadString().Split(" ") ?? [];

        int A = int.Parse(vet[0]);
        int B = int.Parse(vet[1]);
        int C = int.Parse(vet[2]);
        int D = int.Parse(vet[3]);

        int DIFERENCA = (A*B - C*D);

        Console.WriteLine($"DIFERENÇA = {DIFERENCA}");
    }

}
