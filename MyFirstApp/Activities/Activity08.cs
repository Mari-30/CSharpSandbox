namespace MyFirstApp.Activities;

public class Activity08 : IProgram
{
    public void Run()
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
}
