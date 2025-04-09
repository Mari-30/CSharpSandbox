namespace MyFirstApp;

internal static class ConsoleExtensions
{
    public static string ReadString()
    {
        return Console.ReadLine() ?? string.Empty;
    }

    public static double? ReadDouble(bool repeatWhenInvalid = false, string? question = null)
    {
        WriteQuestionIfNotNull(question);
        do
        {
            bool result = double.TryParse(Console.ReadLine(), out double value);

            if (!result)
            {
                WriteValueConversionFailedMessage(repeatWhenInvalid);
            }
            else
            {
                return value;
            }

        } while (repeatWhenInvalid);

        return null;
    }

    public static char? ReadChar(bool repeatWhenInvalid = false, string? question = null)
    {
        WriteQuestionIfNotNull(question);
        do
        {
            bool result = char.TryParse(Console.ReadLine(), out char value);

            if (!result)
            {
                WriteValueConversionFailedMessage(repeatWhenInvalid);
            }
            else
            {
                return value;
            }

        } while (repeatWhenInvalid);

        return null;
    }

    public static int? ReadInt(bool repeatWhenInvalid = false, string? question = null)
    {
        return ReadDouble(repeatWhenInvalid, question).ToInt();
    }

    public static int? ToInt(this double? value) => (int?)value;

    private static void WriteValueConversionFailedMessage(bool withSuffix = false)
    {
        var suffixMessage = withSuffix ? " Tente novamente." : string.Empty;
        Console.WriteLine($"Valor inválido!{suffixMessage}");
    }

    private static void WriteQuestionIfNotNull(string? question)
    {
        if (question == null) return;
        Console.WriteLine(question);
    }
}
