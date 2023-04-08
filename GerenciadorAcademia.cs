using System;
using System.Linq;

public class GerenciadorAcademia
{
    private Academia _academia;

    public GerenciadorAcademia(Academia academia)
    {
        _academia = academia;
    }

    public void CadastrarAluno(string nome, string cpf, DateTime dataNascimento, decimal valorPagamento = 0)
    {
        Aluno alunoExistente = _academia.Alunos.Find(a => a.CPF == cpf);
        AcademiaException.ValidarCPFExistente(alunoExistente);
        AcademiaException.ValidarVagasDisponiveis(_academia.VagasDisponiveis);

        Aluno novoAluno = new Aluno
        {
            Nome = nome,
            CPF = cpf,
            DataNascimento = dataNascimento,
            StatusPagamento = valorPagamento > 0 ? StatusPagamento.Pago : StatusPagamento.APagar
        };

        _academia.Alunos.Add(novoAluno);
        _academia.VagasDisponiveis--;

        if (valorPagamento > 0)
        {
            _academia.ValorEmCaixa += valorPagamento;
        }
    }

    public void EfetuarPagamento(string cpf, decimal valorPagamento)
    {
        Aluno aluno = _academia.Alunos.Find(a => a.CPF == cpf);
        AcademiaException.ValidarCPFEncontrado(aluno);
        AcademiaException.ValidarPagamentoEfetuado(aluno.StatusPagamento);

        aluno.StatusPagamento = StatusPagamento.Pago;
        _academia.ValorEmCaixa += valorPagamento;
    }

    public void CancelarAluno(string cpf)
    {
        Aluno aluno = _academia.Alunos.Find(a => a.CPF == cpf);
        AcademiaException.ValidarCPFEncontrado(aluno);
        AcademiaException.ValidarPagamentoPendente(aluno.StatusPagamento);

        _academia.Alunos.Remove(aluno);
        _academia.VagasDisponiveis++;
    }
}
