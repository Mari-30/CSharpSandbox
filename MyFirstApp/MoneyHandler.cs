namespace MyFirstApp;

public class MoneyHandler
{
    public static Dictionary<int, int> NoteCount(double value)
    {
        // Dicionário de contagem de notas:
        // Chave: nota (cédula)
        // Valor: contagem da respectiva nota

        var result = new Dictionary<int, int>()
        {
            { 100, 0 },
            { 50, 0 },
            { 20, 0 },
            { 10, 0 },
            { 5, 0 },
            { 2, 0 },
            { 1, 0 },
        };
        var integerValue = (int)value;
        var index = 0;

        while (integerValue > 0)
        {
            var noteCount = result.ElementAt(index);
            if (integerValue >= noteCount.Key)
            {
                integerValue -= noteCount.Key;
                result[noteCount.Key]++;
            }
            else
            {
                index++;
            }
        }

        return result;
    }
}
