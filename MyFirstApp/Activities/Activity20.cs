namespace MyFirstApp.Activities;

public class Activity20 : IProgram
{
    public void Run()
    {
        Console.WriteLine("Atividade 20: Conversor de tempo");
        int N, horas, resto, minutos, segundos;

        N = int.Parse(Console.ReadLine());

        horas = N / 3600;
        resto = N % 3600;

        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }
}
