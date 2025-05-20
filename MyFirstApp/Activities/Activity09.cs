namespace MyFirstApp.Activities;

public class Activity09 : IProgram
{
    public void Run()
    {
        //Exercicio 1008 URI

        Console.WriteLine("Digite seu nome: ");
        string? employeeName = ConsoleExtensions.ReadString();
        int? id = ConsoleExtensions.ReadInt(true, "ID: ");
        double? horasTrabalhadas = ConsoleExtensions.ReadDouble(true, "Working hours: ");
        double? valorDaHora = ConsoleExtensions.ReadDouble(true, "Hourly Rate ");


        double? salary = horasTrabalhadas * valorDaHora;

        Console.WriteLine($"Dados do Funcionario \nName:{employeeName} \nID: {id} \n" +
            $"Horas trabalhadas: {horasTrabalhadas} \nSalari: R${salary}");
    }
}
