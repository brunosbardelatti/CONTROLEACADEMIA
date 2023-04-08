using System.Collections.Generic;

public class Academia
{
    private string _nome;
    private int _vagasDisponiveis;
    private decimal _valorEmCaixa;
    private List<Aluno> _alunos;

    public string Nome
    {
        get => _nome;
        set
        {
            AcademiaException.ValidarNome(value);
            _nome = value;
        }
    }

    public int VagasDisponiveis
    {
        get => _vagasDisponiveis;
        set
        {
           AcademiaException.ValidarVagas(value);
            _vagasDisponiveis = value;
        }
    }

    public decimal ValorEmCaixa
    {
        get => _valorEmCaixa;
        set
        {
            AcademiaException.ValidarCaixa(value);
            _valorEmCaixa = value;
        }
    }

    public List<Aluno> Alunos => _alunos ??= new List<Aluno>();
}
