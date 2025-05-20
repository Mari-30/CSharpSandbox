namespace MyFirstApp.Activities;

public class Activity06 : IProgram
{
    public void Run()
    {
        int A, B, soma;

        Console.WriteLine("Digite um valor para A: ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para B: ");
        B = int.Parse(Console.ReadLine());

        soma = A + B;

        Console.WriteLine($"SOMA={soma}");
    }
}
