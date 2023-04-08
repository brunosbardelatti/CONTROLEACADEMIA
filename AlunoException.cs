using System;

public class AlunoException : Exception
{
    public static void ValidarNome(string nome)
    {
        if (string.IsNullOrEmpty(nome) || nome.Length < 2)
        {
            throw new ArgumentException("O nome do aluno deve ter pelo menos 2 caracteres.");
        }
    }

    public static void ValidarCPF(string cpf)
    {
        if (cpf.Length != 11)
        {
            throw new ArgumentException("O CPF deve conter exatamente 11 dígitos.");
        }
        if (cpf.Length == 13)
        {
           throw new ArgumentException("Voce digitou um CNPJ com 13 dígitos, CPF contem 11 dígitos."); 
        }
        if (string.IsNullOrEmpty(cpf))
        {
            throw new ArgumentException("O CPF deve ser informado.");
        }
        if (cpf.Contains(".") || cpf.Contains("-"))
        {
            throw new ArgumentException("O CPF não pode conter pontos e traços, digite apenas os numeros.");
        } 
        if (!CPFValido(cpf))
        {
            throw new ArgumentException("O CPF informado não é válido.");
        }       
    }

    public static void ValidarDataNascimento(DateTime dataNascimento)
    {
        if (dataNascimento > DateTime.Now || dataNascimento < DateTime.Now.AddYears(-100))
        {
            throw new ArgumentException("A data de nascimento deve ser válida e não pode ser maior que a data atual.");
        }
    }

    private static bool CPFValido(string cpf)
    {
        int[] multiplicadoresPrimeiroDigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadoresSegundoDigito = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        if (cpf.Length != 11)
            return false;

        for (int j = 0; j < 10; j++)
            if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                return false;

        string tempCpf = cpf.Substring(0, 9);
        int soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresPrimeiroDigito[i];

        int resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        string digito = resto.ToString();
        tempCpf = tempCpf + digito;
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresSegundoDigito[i];

        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        digito = digito + resto.ToString();

        return cpf.EndsWith(digito);
    }
}
