namespace MyFirstApp.Activities;

internal class Activity12 : IProgram
{
    public void Run()
    {
        //carro faz 12km/l

        int mediaConsumo = 12;

        int? tempoGasto = ConsoleExtensions.ReadInt(true, "Tempo da viagem: ");
        int? velMedia = ConsoleExtensions.ReadInt(true, "Velocidade média da viagem: ");

        double? distanciaPercorrida = tempoGasto * velMedia;

        Console.WriteLine($"A distancia percorrida durante a viagem é: {distanciaPercorrida}km");

        double? qtdLitros = distanciaPercorrida / mediaConsumo;

        Console.WriteLine($"{qtdLitros:F2}L");
    }
}
