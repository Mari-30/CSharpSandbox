namespace MyFirstApp.Activities;

//Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, 
//iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar,
//uma vez que ele sabe quando inicia e quando termina o evento.

//Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

//Entrada
//Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar.
//Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. 
//Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas,
//indicando o término do evento.

public class Activity24 : IProgram
{
    public void Run()
    {
        int diaInicio = ConsoleExtensions.ReadInt(true, "Incio dia: ")!.Value;
        int h, m, s;

        Console.WriteLine("Inicio horas: ");
        string[] horaInicio = ConsoleExtensions.ReadString().Split(':');


        h = int.Parse(horaInicio[0]);
        m = int.Parse(horaInicio[1]);
        s = int.Parse(horaInicio[2]);

        int segundosInicio = Utils.TotalSeconds(diaInicio, h, m, s);


        int diaTermino = ConsoleExtensions.ReadInt(true, "Incio dia: ")!.Value;
        Console.WriteLine("Termino horas: ");
        string[] horaTermino = ConsoleExtensions.ReadString().Split(':');

        h = int.Parse(horaInicio[0]);
        m = int.Parse(horaInicio[1]);
        s = int.Parse(horaInicio[2]);

        int totalSeconds = Utils.TotalSeconds(diaTermino, h, m, s) - segundosInicio;
        Console.WriteLine(totalSeconds);
        int days = totalSeconds / (3600 * 24);

        int hours = (totalSeconds % (3600 * 24)) / 24;

        int minutes = (totalSeconds % 3600) / 60;

        int seconds = (totalSeconds % 60);


        Console.WriteLine($"Dias: {days} \n{hours}:{minutes}:{seconds}");

        //horas = n / 3600;
        //minutos = (n % 3600) / 60;
        //segundos = n % 60;
    }
}
