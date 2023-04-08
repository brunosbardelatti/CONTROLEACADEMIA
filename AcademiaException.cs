using System;

public class AcademiaException : Exception
{
    public AcademiaException(string message) : base(message) { }

    public static void ValidarNome(string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            throw new AcademiaException("O nome não pode ser vazio ou nulo.");
        }
    }

    public static void ValidarVagas(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("O número de vagas disponíveis não pode ser negativo.");
        }
    }

    public static void ValidarCaixa(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("O valor em caixa não pode ser negativo.");
        }
    }

    public static void ValidarVagasDisponiveis(int vagasDisponiveis)
    {
        if (vagasDisponiveis <= 0)
        {
            throw new AcademiaException("Não há vagas disponíveis na academia.");
        }
    }

    public static void ValidarCPFExistente(Aluno aluno)
    {
        if (aluno != null)
        {
            throw new AcademiaException("CPF já cadastrado no sistema.");
        }
    }

    public static void ValidarCPFEncontrado(Aluno aluno)
    {
        if (aluno == null)
        {
            throw new AcademiaException("CPF não encontrado no sistema.");
        }
    }

    public static void ValidarPagamentoEfetuado(StatusPagamento statusPagamento)
    {
        if (statusPagamento == StatusPagamento.Pago)
        {
            throw new AcademiaException("Aluno já efetuou o pagamento.");
        }
    }

    public static void ValidarPagamentoPendente(StatusPagamento statusPagamento)
    {
        if (statusPagamento != StatusPagamento.Pago)
        {
            throw new AcademiaException("Não é possível cancelar o aluno com pagamento pendente.");
        }
    }
}
