namespace MyFirstApp.Activities;

public class Activity07 : IProgram
{
    public void Run()
    {

        //Exercicio 1004 URI

        int x, y, PROD;

        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());

        Console.Write("y = ");
        y = int.Parse(Console.ReadLine());

        PROD = x * y;

        Console.WriteLine($"PROD = {PROD}");
    }
}
