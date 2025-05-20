namespace MyFirstApp.Activities;

internal class Activity15 : IProgram
{
    public void Run()
    {

        Console.WriteLine("Employee Name: ");
        string? employeeName = ConsoleExtensions.ReadString();
        double? salary = ConsoleExtensions.ReadDouble(true, "Month Salary");
        int? numOfSales = ConsoleExtensions.ReadInt(true, "Number of sales");

        double? totalSalary = (numOfSales * 0.15) + salary;

        Console.WriteLine($"TOTAL = R${totalSalary:f2}");
    }
}
