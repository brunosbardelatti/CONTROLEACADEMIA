using System;

class Program
{
    static void Main(string[] args)
    {
        string nomeAcademia = InterfaceUsuario.ObterString("Digite o nome da academia:");
        int vagasDisponiveis = InterfaceUsuario.ObterInteiro("Digite o número de vagas disponíveis:");
        decimal valorEmCaixa = InterfaceUsuario.ObterDecimal("Digite o valor em caixa:");

        Academia academia = new Academia
        {
            Nome = nomeAcademia,
            VagasDisponiveis = vagasDisponiveis,
            ValorEmCaixa = valorEmCaixa
        };

        GerenciadorAcademia gerenciador = new GerenciadorAcademia(academia);

        int opcao = 0;
        while (opcao != 4)
        {
            ExibirMenu();
            opcao = InterfaceUsuario.ObterInteiro("");

            try
            {
                switch (opcao)
                {
                    case 1:
                        // Cadastrar aluno
                        CadastrarAluno(gerenciador);
                        break;
                    case 2:
                        // Efetuar pagamento
                        EfetuarPagamento(gerenciador);
                        break;
                    case 3:
                        // Cancelar aluno
                        CancelarAluno(gerenciador);
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            catch (AcademiaException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (AlunoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Efetuar pagamento");
        Console.WriteLine("3 - Cancelar aluno");
        Console.WriteLine("4 - Sair");
    }

    static void CadastrarAluno(GerenciadorAcademia gerenciador)
    {
        string nome = InterfaceUsuario.ObterString("Digite o nome do aluno:");
        string cpf = InterfaceUsuario.ObterString("Digite o CPF do aluno:");
        DateTime dataNascimento = InterfaceUsuario.ObterData("Digite a data de nascimento do aluno (dd/MM/yyyy):");
        decimal valorPagamento = InterfaceUsuario.ObterDecimal("Digite o valor do pagamento (caso deseje efetuar pagamento):");

        gerenciador.CadastrarAluno(nome, cpf, dataNascimento, valorPagamento);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void EfetuarPagamento(GerenciadorAcademia gerenciador)
    {
        string cpf = InterfaceUsuario.ObterString("Digite o CPF do aluno:");
        decimal valorPagamento = InterfaceUsuario.ObterDecimal("Digite o valor do pagamento:");

        gerenciador.EfetuarPagamento(cpf, valorPagamento);
        Console.WriteLine("Pagamento efetuado com sucesso!");
    }

    static void CancelarAluno(GerenciadorAcademia gerenciador)
    {
        string cpf = InterfaceUsuario.ObterString("Digite o CPF do aluno:");

        gerenciador.CancelarAluno(cpf);
        Console.WriteLine("Aluno cancelado com sucesso!");
    }
}
