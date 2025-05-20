namespace MyFirstApp.Activities;

/*
 * Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi
 * o valor 3.14159.

    Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.

    Entrada
    O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

    Saída
    A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.
 */

public class Activity16 : IProgram
{
    public void Run()
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
}
