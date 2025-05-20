namespace MyFirstApp.Activities;

public class Activity01 : IProgram
{
    public void Run()
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
}
