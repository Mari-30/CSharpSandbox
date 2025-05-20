namespace MyFirstApp.Activities;

public class Activity04 : IProgram
{
    public void Run()
    {
        double? area, preco;

        double? largura = ConsoleExtensions.ReadDouble(true, "Insira a largura do terreno: ");
        double? comprimento = ConsoleExtensions.ReadDouble(true, "Insira o comprimento: ");
        double? valor = ConsoleExtensions.ReadDouble(true, "Insira o valor da area: ");

        area = largura * comprimento;
        preco = area * valor;

        Console.WriteLine("A area do terreno é: " + area);
        Console.WriteLine("O preço do terreno é: " + preco);
    }
}
