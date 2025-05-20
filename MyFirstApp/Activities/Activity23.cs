namespace MyFirstApp.Activities;

//URI 1020

//Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

//Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
//Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
//Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

//Entrada
//        O arquivo de entrada contém um valor inteiro.

//Saída
//        Imprima a saída conforme exemplo fornecido.

public class Activity23 : IProgram
{
    public void Run()
    {
        Console.WriteLine("Idade em Ano, Meses e Dias");

        int? totalDias = ConsoleExtensions.ReadInt(true, "Digite a sua idade em dias: ")!.Value;

        int? ano = totalDias / 365;
        int? diasRestantes = (totalDias % 365);
        int? meses = diasRestantes / 30;
        int? dias = diasRestantes % 30;

        Console.WriteLine($"{ano}ano(s) \n{meses}mes(es) \n{dias}dia(s)");
    }
}
