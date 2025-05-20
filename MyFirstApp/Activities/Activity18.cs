namespace MyFirstApp.Activities;

/*
    Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

    Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

    Entrada
    O arquivo de entrada contém três valores inteiros.

    Saída
    Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/

public class Activity18 : IProgram
{
    public void Run()
    {
        //URI 1013

        double? a = ConsoleExtensions.ReadDouble(true, "Digite o valor para A: ");
        double? b = ConsoleExtensions.ReadDouble(true, "Digite o valor para B: ");
        double? c = ConsoleExtensions.ReadDouble(true, "Digite o valor para C: ");

        double? maior = Math.Max(Math.Max(a.GetValueOrDefault(), b.GetValueOrDefault()), c.GetValueOrDefault());

        Console.WriteLine($"O maior numero é: {maior}");
    }
}
