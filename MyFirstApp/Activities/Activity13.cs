namespace MyFirstApp.Activities;

internal class Activity13 : IProgram
{
    public void Run()
    {

        double? @base = ConsoleExtensions.ReadDouble(true, "Base: ");
        double? altura = ConsoleExtensions.ReadDouble(true, "Altura: ");

        double? area = @base * altura;
        double? perimetro = 2 * (@base + altura);
        double? diagonal = Math.Sqrt(Math.Pow(@base ?? 0, 2) + Math.Pow(altura ?? 0, 2));

        Console.WriteLine($"Área = {area}\nPerimetro = {perimetro}\nDiagonal = {diagonal}");

    }
}
