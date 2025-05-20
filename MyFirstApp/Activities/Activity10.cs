namespace MyFirstApp.Activities;

public class Activity10 : IProgram
{
    public void Run()
    {
        //Exercicio 1010 URI

        //codigo da peça, numero da peça, valor unitario
        //dois inteiros, double

        string[] peca1 = ConsoleExtensions.ReadString().Split(' ') ?? [];
        string[] peca2 = ConsoleExtensions.ReadString().Split(' ') ?? [];

        int codigoP1 = int.Parse(peca1[0]);
        int numPecaP1 = int.Parse(peca1[1]);
        double valorUnitP1 = double.Parse(peca1[2]);

        int codigoP2 = int.Parse(peca2[0]);
        int numPecaP2 = int.Parse(peca2[1]);
        double valorUnitP2 = double.Parse(peca2[2]);

        double valorPagar = (valorUnitP1 * numPecaP1 + valorUnitP2 * numPecaP2);

        Console.WriteLine($"Valor a Pagar: R$ {valorPagar}");
    }
}
