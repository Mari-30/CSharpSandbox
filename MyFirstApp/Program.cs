namespace MyFirstApp;

class Program
{
    public static void Main(string[] args)
    {
        CreateActivity().Run();
    }

    private static int InputActivity()
    {
        return ConsoleExtensions.ReadInt(true, "Digite o número da atividade:")!.Value;
    }

    private static IProgram CreateActivity()
    {
        var activity = InputActivity();

        return ProgramFactory.Create(activity);
    }
}
