using System;

public class Aluno
{
    private string _nome;
    private string _cpf;
    private DateTime _dataNascimento;

    // public Aluno(string nome, string cpf, DateTime dataNascimento, StatusPagamento statusPagamento = StatusPagamento.APagar)
    // {
    //     _nome = nome ?? string.Empty;
    //     _cpf = cpf ?? string.Empty;
    //     _dataNascimento = dataNascimento;
    //     _statusPagamento = statusPagamento;
    // }
    public string Nome
    {
        get => _nome;
        set
        {
            // if (string.IsNullOrWhiteSpace(value))
            // {
            //     throw new ArgumentException("O nome do aluno não pode ser vazio ou nulo.");
            // }
            AlunoException.ValidarNome(value);
            _nome = value;
        }
    }

    public string CPF
    {
        get => _cpf;
        set
        {
            // if (string.IsNullOrWhiteSpace(value))
            // {
            //     throw new ArgumentException("O CPF do aluno não pode ser vazio ou nulo.");
            // }
            AlunoException.ValidarCPF(value);
            // Você pode adicionar validações adicionais para o formato do CPF aqui.
            _cpf = value;
        }
    }
    public DateTime DataNascimento
    {
        get => _dataNascimento;
        set
        {
            // if (value > DateTime.Now)
            // {
            //     throw new ArgumentException("A data de nascimento não pode ser no futuro.");
            // }
            AlunoException.ValidarDataNascimento(value);
            _dataNascimento = value;
        }
    }

    public StatusPagamento StatusPagamento { get; set; }

}