namespace MyFirstApp.Activities;

public class Activity26 : IProgram
{
    public void Run()
    {
        int A, B;
        Console.WriteLine("Digite um valor para A: ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para B: ");
        B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
        {

            Console.WriteLine("Valores Aceitos");

        }

        else
        {
            Console.WriteLine("Não são multiplos");
        }
    }
}
