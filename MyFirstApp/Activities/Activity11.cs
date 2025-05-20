namespace MyFirstApp.Activities;

internal class Activity11 : IProgram
{
    public void Run()
    {
        //Exercicio 1014 URI
        //consumo médio
        //Entrada: Distancia total percorrida km e Total de combustivel gasto em L
        // X = DISTANCIA Y TOTAL COMBUSTIVEL

        double? X = ConsoleExtensions.ReadInt(true, "Distancia total Percorrida: ");
        double? Y = ConsoleExtensions.ReadDouble(true, "Combustivel gasto: ");

        double? media = X / Y;

        Console.WriteLine($"Média = {media}km/l");
    }
}
