namespace MyFirstApp.Activities;

public class Activity27 : IProgram
{
    public void Run()
    {
        double salario, novoSalario;
        Console.WriteLine("Digite seu salário: ");
        salario = double.Parse(Console.ReadLine());

        if (salario > 0 && salario < 400.01)
        {
            novoSalario = salario + salario * 0.15;
            Console.WriteLine($"Novo salario: R${novoSalario:f2} \nReajuste ganho: R${novoSalario - salario:f2}\nEm porcentagem: 15%");

        }
        else if (salario > 400.00 && salario < 800.01)
        {
            novoSalario = salario + salario * 0.12;
            Console.WriteLine($"Novo salario: R${novoSalario:f2} \nReajuste ganho: R${novoSalario - salario:f2}\nEm porcentagem: 12%");

        }
        else if (salario > 800.00 && salario < 1200.01)
        {
            novoSalario = salario + salario * 0.10;
            Console.WriteLine($"Novo salario: R${novoSalario:f2} \nReajuste ganho: R${novoSalario - salario:f2}\nEm porcentagem: 10%");

        }
        else if (salario > 1200 && salario < 2000.01)
        {
            novoSalario = salario + salario * 0.07;
            Console.WriteLine($"Novo salario: R${novoSalario:f2} \nReajuste ganho: R${novoSalario - salario:f2}\nEm porcentagem: 7%");

        }
        else
        {
            novoSalario = salario + salario * 0.04;
            Console.WriteLine($"Novo salario: R${novoSalario:f2} \nReajuste ganho: R${novoSalario - salario:f2}\nEm porcentagem: 4%");

        }
    }
}
