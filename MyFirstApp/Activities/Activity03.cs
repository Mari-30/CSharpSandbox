namespace MyFirstApp.Activities;

public class Activity03 : IProgram
{
    public void Run()
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
}
