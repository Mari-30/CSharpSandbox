namespace MyFirstApp.Activities;

public class Activity14 : IProgram
{
    public void Run()
    {

        string nomeA, nomeB;
        int idadeA, idadeB;

        double media;

        string[] vet;

        vet = Console.ReadLine().Split(' ');
        nomeA = vet[0];
        idadeA = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(' ');
        nomeB = vet[0];
        idadeB = int.Parse(vet[1]);

        media = (double)(idadeA + idadeB) / 2.0;

        Console.WriteLine($"A média de idade de {nomeA} e {nomeB} é de {media}");
    }
}
