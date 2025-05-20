namespace MyFirstApp.Activities;

//URI 1018
//Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

//Entrada
//O arquivo de entrada contém um valor inteiro N.

//Saída
//Imprima o tempo lido no arquivo de entrada(segundos), convertido para horas: minutos: segundos, conforme exemplo fornecido.

internal class Activity21 : IProgram
{
    public void Run()
    {
        int n, horas, minutos, segundos;
        n = int.Parse(Console.ReadLine());

        horas = n / 3600;
        minutos = (n % 3600) / 60;
        segundos = n % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }
}
