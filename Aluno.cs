using System;

public class Aluno
{
    private string _nome;
    private string _cpf;
    private DateTime _dataNascimento;

    public string Nome
    {
        get => _nome;
        set
        {
            AlunoException.ValidarNome(value);
            _nome = value;
        }
    }

    public string CPF
    {
        get => _cpf;
        set
        {
            AlunoException.ValidarCPF(value);
            _cpf = value;
        }
    }
    public DateTime DataNascimento
    {
        get => _dataNascimento;
        set
        {
            AlunoException.ValidarDataNascimento(value);
            _dataNascimento = value;
        }
    }

    public StatusPagamento StatusPagamento { get; set; }

}