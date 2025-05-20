namespace MyFirstApp.Activities;

/*
    Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

    Distancia =

    Entrada
    O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

    Saída
    Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
 */

public class Activity19 : IProgram
{
    public void Run()
    {
        //URI 1015

        Console.WriteLine("Programa que calcula distância entre pontos. Exemplo:");
        Console.WriteLine("Input (Ponto A): 2 3");
        Console.WriteLine("Input (Ponto B): 5 7");
        Console.WriteLine("Output: 2,24\n");

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
    }
}
