namespace MyFirstApp.Activities;

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

public class Activity17 : IProgram
{
    public void Run()
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
}
