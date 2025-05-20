namespace MyFirstApp.Activities;

public class Activity05 : IProgram
{
    public void Run()
    {
        double? raio = ConsoleExtensions.ReadDouble(true, "insira o valor do raio: ");

        double n = 3.14159;

        double? area = n * (raio * raio);

        Console.WriteLine($"O valor da area é {area}");
    }
}
