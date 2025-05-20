namespace MyFirstApp.Activities;

internal class Activity28 : IProgram
{
    public void Run()
    {
        int chaBranco, chaVerde, chaPreto, chaErvas, cha;

        chaBranco = 1;
        chaVerde = 2;
        chaPreto = 3;
        chaErvas = 4;

        Console.WriteLine("Sabor do Chá:");
        cha = int.Parse(Console.ReadLine());
    }
}
