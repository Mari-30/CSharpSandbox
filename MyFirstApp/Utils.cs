﻿using System.Text.Json;

namespace MyFirstApp;

public static class Utils
{
    public static string ToJson(this object @object)
    {
        return JsonSerializer.Serialize(@object, new JsonSerializerOptions
        {
            WriteIndented = true,
        });
    }

    public static void LoopProgram(this Action program)
    {
        while(true)
        {
            program.Invoke();
            Console.Write("Deseja executar novamente? y/n");
            ConsoleKey response;
            while (true)
            {
                response = Console.ReadKey(true).Key;
                if (response == ConsoleKey.Y || response == ConsoleKey.N) break;
            }
            if (response == ConsoleKey.N) break;
            Console.WriteLine();
        }
    }
}
