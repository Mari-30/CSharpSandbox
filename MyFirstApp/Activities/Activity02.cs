namespace MyFirstApp.Activities;

public class Activity02 : IProgram
{
    public void Run()
    {
        string frase = ConsoleExtensions.ReadString();
        string x = ConsoleExtensions.ReadString();
        string y = ConsoleExtensions.ReadString();
        string z = ConsoleExtensions.ReadString();

        string[] v = ConsoleExtensions.ReadString().Split(' ') ?? [];

        if (v.Length >= 3)
        {
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
