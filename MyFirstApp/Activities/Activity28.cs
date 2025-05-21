namespace MyFirstApp.Activities;

//    Degustação de chá às escuras é a habilidade de identificar um chá usando apenas seus sentidos do olfato e paladar.
//Isto faz parte da Competição Ideal de Consumidores de Chá Puro (da sigla em inglês ICPC), que um programa de TV local está organizando.Durante o show, um bule de chá completo é preparado e são entregues uma xícara de chá para cada um dos cinco competidores.Os participantes devem cheirar, saborear e avaliar a amostra, de modo a identificar o tipo de chá, que pode ser: (1) o chá branco; (2) chá verde; (3) chá preto; ou(4) chá de ervas.No final, as respostas são verificadas para determinar o número de suposições corretas.
//Dado o tipo de chá real e as respostas fornecidas, determinar o número de participantes que receberam a resposta correta.

//Entrada
//A primeira linha contém um inteiro T representando o tipo de chá (1 ≤ T ≤ 4). A segunda linha contém cinco inteiros A, B, C, D e E, que indica a resposta dada por cada competidor(1 ≤ A, B, C, D, E ≤ 4).

//Saída
//A saída contém um inteiro representando o número de concorrentes que obtiveram a resposta correta.

internal class Activity28 : IProgram
{
    private List<Cha> _chas = [];
    private List<Participante> _participantes = [];
    private List<Palpite> _palpites = [];
    private Cha _chaSorteado;

    public void Run()
    {
        CarregarChas();
        CarregarParticipantes();
        SortearCha();
        LerPalpites();
        ExibirResultado();
    }

    private void LerPalpites()
    {
        foreach (var participante in _participantes)
        {
            var label = $"Participante '{participante.Nome}', dê seu palpite (número do chá):";
            int numero = ConsoleExtensions.ReadInt(true, label)!.Value;
            var resposta = _chas.First(c => c.Numero == numero);

            _palpites.Add(new Palpite(participante, resposta));
        }
    }

    private void SortearCha()
    {
        _chaSorteado = _chas.Random();
    }

    private void ExibirResultado()
    {
        int totalAcertos = _palpites.Count(p => p.Resposta == _chaSorteado);

        Console.WriteLine($"Chá escolhido foi: {_chaSorteado.Nome}");
        Console.WriteLine($"Total de acertos: {totalAcertos}");
    }

    private void CarregarChas()
    {
        _chas.Add(new Cha("Chá branco", 1));
        _chas.Add(new Cha("Chá verde", 2));
        _chas.Add(new Cha("Chá preto", 3));
        _chas.Add(new Cha("Chá de ervas", 4));
    }

    private void CarregarParticipantes()
    {
        _participantes.Add(new Participante("A"));
        _participantes.Add(new Participante("B"));
        _participantes.Add(new Participante("C"));
        _participantes.Add(new Participante("D"));
        _participantes.Add(new Participante("E"));
    }
}

public class Cha
{
    public Cha(string nome, int numero)
    {
        Nome = nome;
        Numero = numero;
    }

    public string Nome { get; }
    public int Numero { get; }
}

public class Participante
{
    public Participante(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
}

public class Palpite
{
    public Palpite(Participante participante, Cha resposta)
    {
        Participante = participante;
        Resposta = resposta;
    }

    public Participante Participante { get; }
    public Cha Resposta { get; }
}
