using System;
using System.Globalization;

public class InterfaceUsuario
{
    public static int ObterInteiro(string mensagem)
    {
        int resultado;
        while (true)
        {
            Console.WriteLine(mensagem);
            if (int.TryParse(Console.ReadLine(), out resultado))
            {
                break;
            }
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
        return resultado;
    }

    public static decimal ObterDecimal(string mensagem)
    {
        decimal resultado;
        while (true)
        {
            Console.WriteLine(mensagem);
            if (decimal.TryParse(Console.ReadLine(), out resultado))
            {
                break;
            }
            Console.WriteLine("Por favor, insira um número decimal válido.");
        }
        return resultado;
    }

    public static DateTime ObterData(string mensagem)
    {
        DateTime resultado;
        string formato = "dd/MM/yyyy";
        while (true)
        {
            Console.WriteLine(mensagem);
            if (DateTime.TryParseExact(Console.ReadLine(), formato, null, DateTimeStyles.None, out resultado))
            {
                break;
            }
            Console.WriteLine($"Por favor, insira uma data válida no formato {formato}.");
        }
        return resultado;
    }

    public static string ObterString(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

}


