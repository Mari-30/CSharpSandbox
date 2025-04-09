using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        catch (Exception)
        {
            Console.WriteLine("Um erro inesperado ocorreu");
        }
    }
    public static void Activity02()
    {

        string frase = ConsoleExtensions.ReadString();
        string x = ConsoleExtensions.ReadString();
        string y = ConsoleExtensions.ReadString();
        string z = ConsoleExtensions.ReadString();

        string[] v = ConsoleExtensions.ReadString().Split(' ') ?? [];

        if (v.Length >= 3)
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
    public static void Activity03()
    {

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

    public static void Activity04()
    {

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

    public static void Activity07()
    {

        //Exercicio 1004 URI

        int x, y, PROD;

        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());

        Console.Write("y = ");
        y = int.Parse(Console.ReadLine());

        PROD = x * y;

        Console.WriteLine($"PROD = {PROD}");

    }

    public static void Activity08()
    {

        //Exercicio 1007 URI

        string[] vet = ConsoleExtensions.ReadString().Split(" ") ?? [];

        int A = int.Parse(vet[0]);
        int B = int.Parse(vet[1]);
        int C = int.Parse(vet[2]);
        int D = int.Parse(vet[3]);

        int DIFERENCA = (A * B - C * D);

        Console.WriteLine($"DIFERENÇA = {DIFERENCA}");
    }

    public static void Activity09()
    {
        //Exercicio 1008 URI

        Console.WriteLine("Digite seu nome: ");
        string? employeeName = ConsoleExtensions.ReadString();
        int? id = ConsoleExtensions.ReadInt(true, "ID: ");
        double? horasTrabalhadas = ConsoleExtensions.ReadDouble(true, "Working hours: ");
        double? valorDaHora = ConsoleExtensions.ReadDouble(true, "Hourly Rate ");


        double? salary = horasTrabalhadas * valorDaHora;

        Console.WriteLine($"Dados do Funcionario \nName:{employeeName} \nID: {id} \n" +
            $"Horas trabalhadas: {horasTrabalhadas} \nSalari: R${salary}");

    }
    public static void Activity10()
    {
        //Exercicio 1010 URI

        //codigo da peça, numero da peça, valor unitario
        //dois inteiros, double

        string[] peca1 = ConsoleExtensions.ReadString().Split(' ') ?? [];
        string[] peca2 = ConsoleExtensions.ReadString().Split(' ') ?? [];

        int codigoP1 = int.Parse(peca1[0]);
        int numPecaP1 = int.Parse(peca1[1]);
        double valorUnitP1 = double.Parse(peca1[2]);

        int codigoP2 = int.Parse(peca2[0]);
        int numPecaP2 = int.Parse(peca2[1]);
        double valorUnitP2 = double.Parse(peca2[2]);

        double valorPagar = (valorUnitP1 * numPecaP1 + valorUnitP2 * numPecaP2);

        Console.WriteLine($"Valor a Pagar: R$ {valorPagar}");

    }

    public static void Activity11()
    {

        //Exercicio 1014 URI
        //consumo médio
        //Entrada: Distancia total percorrida km e Total de combustivel gasto em L
        // X = DISTANCIA Y TOTAL COMBUSTIVEL

        double? X = ConsoleExtensions.ReadInt(true, "Distancia total Percorrida: ");
        double? Y = ConsoleExtensions.ReadDouble(true, "Combustivel gasto: ");

        double? media = X / Y;

        Console.WriteLine($"Média = {media}km/l");

    }

    public static void Activity12()
    {
        //carro faz 12km/l

        int mediaConsumo = 12;

        int? tempoGasto = ConsoleExtensions.ReadInt(true, "Tempo da viagem: ");
        int? velMedia = ConsoleExtensions.ReadInt(true, "Velocidade média da viagem: ");

        double? distanciaPercorrida = tempoGasto * velMedia;

        Console.WriteLine($"A distancia percorrida durante a viagem é: {distanciaPercorrida}km");

        double? qtdLitros = distanciaPercorrida / mediaConsumo;

        Console.WriteLine($"{qtdLitros:F2}L");

    }

    public static void Activity13()
    {

        double? @base = ConsoleExtensions.ReadDouble(true, "Base: ");
        double? altura = ConsoleExtensions.ReadDouble(true, "Altura: ");

        double? area = @base * altura;
        double? perimetro = 2 * (@base + altura);
        double? diagonal = Math.Sqrt(Math.Pow(@base ?? 0, 2) + Math.Pow(altura ?? 0, 2));

        Console.WriteLine($"Área = {area}\nPerimetro = {perimetro}\nDiagonal = {diagonal}");


    }

    public static void Activity14()
    {

        string nomeA, nomeB;
        int idadeA, idadeB;

        double media;

        string[] vet;

        vet = Console.ReadLine().Split(' ');
        nomeA = vet[0];
        idadeA = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(' ');
        nomeB = vet[0];
        idadeB = int.Parse(vet[1]);

        media = (double)(idadeA + idadeB) / 2.0;

        Console.WriteLine($"A média de idade de {nomeA} e {nomeB} é de {media}");


    }
    public static void Activity15()
    {
        Console.WriteLine("Employee Name: ");
        string? employeeName = ConsoleExtensions.ReadString();
        double? salary = ConsoleExtensions.ReadDouble(true, "Month Salary");
        int? numOfSales = ConsoleExtensions.ReadInt(true, "Number of sales");

        double? totalSalary = (numOfSales * 0.15) + salary;

        Console.WriteLine($"TOTAL = R${totalSalary:f2}");

    }

    /*
     * Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi
     * o valor 3.14159.

        Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.

        Entrada
        O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

        Saída
        A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.
     */

    public static void Activity16()
    {
        double? r3 = ConsoleExtensions.ReadDouble(true, "Digite o valor para R3: ");


        if (r3.HasValue)
        {
            // Calcula o volume com precisão de double
            double vol = MathExtensions.SphereVolum(r3.Value);

            // Se precisar do volume como float, converta explicitamente
            float volFloat = (float)vol;

            Console.WriteLine($"O volume da esfera é: {volFloat} (em formato float) ou {vol} (em formato double).");
        }
        else
        {
            Console.WriteLine("Valor inválido para o raio.");
        }
    }
    /*
        Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        a) a área do triângulo retângulo que tem A por base e C por altura.
        b) a área do círculo de raio C. (pi = 3.14159)
        c) a área do trapézio que tem A e B por bases e C por altura.
        d) a área do quadrado que tem lado B.
        e) a área do retângulo que tem lados A e B.

        Entrada
        O arquivo de entrada contém três valores com um dígito após o ponto decimal.

        Saída
        O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 
        O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

    */
    public static void Activity17()
    {
        //  URI 1012

        double? a = ConsoleExtensions.ReadDouble(true, "Digite o valor para A: ");
        double? b = ConsoleExtensions.ReadDouble(true, "Digite o valor para B: ");
        double? c = ConsoleExtensions.ReadDouble(true, "Digite o valor para C: ");

        double? areaTriangulo = c * a / 2;
        double? areaCirculo = Math.PI * Math.Pow(c ?? 0, 2);
        double? areaTrapezio = (a + b) * c / 2;
        double? areaQuadrado = b * b;
        double? areaRetangulo = a * b;

        Console.WriteLine($"RETANGULO: {areaTriangulo:F3}");
        Console.WriteLine($"RETANGULO: {areaCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

    }
    /*
        Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

        Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

        Entrada
        O arquivo de entrada contém três valores inteiros.

        Saída
        Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
    */
    public static void Activity18()
    {
        //URI 1013

        double? a = ConsoleExtensions.ReadDouble(true, "Digite o valor para A: ");
        double? b = ConsoleExtensions.ReadDouble(true, "Digite o valor para B: ");
        double? c = ConsoleExtensions.ReadDouble(true, "Digite o valor para C: ");

        double? maior = Math.Max(Math.Max(a.GetValueOrDefault(), b.GetValueOrDefault()), c.GetValueOrDefault());

        Console.WriteLine($"O maior numero é: {maior}");

    }

    /*
        Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

        Distancia =

        Entrada
        O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

        Saída
        Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
     */

    public static Action Activity19()
    {
        return () =>
        {
            //URI 1015

            string[] vet1, vet2;
            double x1, x2, y1, y2;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet1[0]);
            x2 = double.Parse(vet1[1]);

            y1 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Distancia: {distancia:f2}");
        };
    }

    public static Action Activity20()
    {
        return () =>
        {
            Console.WriteLine("Atividade 20: Conversor de tempo");
            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        };
    }

    public static Action Activity21()
    {
        //URI 1018
        //Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

        //Entrada
        //O arquivo de entrada contém um valor inteiro N.

        //Saída
        //Imprima o tempo lido no arquivo de entrada(segundos), convertido para horas: minutos: segundos, conforme exemplo fornecido.


        return () =>
        {
            int n, horas, minutos, segundos;
            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            minutos = (n % 3600) / 60;
            segundos = n % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        };
    }
    public static Action Activity22()
    {

        /* 
            Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1
            A seguir mostre o valor lido e a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

            Saída
            Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha
            caso contrário seu programa apresentará a mensagem: “Presentation Error”.
        */

        return () =>
        {
            var valorDinheiro = ConsoleExtensions.ReadDouble(true, "Entre com um valor em reais (R$):")!.Value;
            var result = MoneyHandler.NoteCount(valorDinheiro);

            foreach (var count in result)
            {
                Console.WriteLine($"{count.Value} notas de {count.Key}");
            }
        };
    }
    public static Action Activity23()
    {
        //URI 1020

        //Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

        //Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
        //Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
        //Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

        //Entrada
        //        O arquivo de entrada contém um valor inteiro.

        //Saída
        //        Imprima a saída conforme exemplo fornecido.

        return () =>
        {
            Console.WriteLine("Idade em Ano, Meses e Dias");

            int? totalDias = ConsoleExtensions.ReadInt(true, "Digite a sua idade em dias: ")!.Value;

            int? ano = totalDias / 365;
            int? diasRestantes = (totalDias % 365);
            int? meses = diasRestantes / 30;
            int? dias = diasRestantes % 30;

            Console.WriteLine($"{ano}ano(s) \n{meses}mes(es) \n{dias}dia(s)");


        };


    }
}
