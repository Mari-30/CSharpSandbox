namespace MyFirstApp.Activities;

public class Activity25 : IProgram
{
    public void Run()
    {

        int A, B, C, D;

        Console.WriteLine("digite 4 numeros ");
        string[] num = Console.ReadLine().Split(' ');

        A = int.Parse(num[0]);
        B = int.Parse(num[1]);
        C = int.Parse(num[2]);
        D = int.Parse(num[3]);

        int somaCD = C + D;
        int somaAB = A + B;

        if (A > B && D > A && somaCD > somaAB && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores não aceitos");
        }
    }
}
