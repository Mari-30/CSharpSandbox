namespace MyFirstApp;

internal static class Activities
{
    public static void Activity01()
    {
        while (true) {
            bool result = int.TryParse(Console.ReadLine(), out int number);

            if (result)
            {
                Console.WriteLine($"Você digitou: {number}");
                break;
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente");
            }
     
        }
    }
    public static void Activity02() {

        string frase = ConsoleExtensions.ReadLine();
        string x = ConsoleExtensions.ReadLine();
        string y = ConsoleExtensions.ReadLine();
        string z = ConsoleExtensions.ReadLine();

        string[] v = ConsoleExtensions.ReadLine().Split(' ') ?? [];
        
        if(v.Length >= 3)
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
