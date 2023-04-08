# Desafio Técnico | Estruturas, Controles, Classes, Métodos, Exceções

Escreva um console application usando C# e .NET para um sistema de controle de alunos da academia, respeitando os requisitos abaixo.

## Requisitos

A academia deve ter:

- Nome (string)
- Vagas disponíveis (inteiro)
- Valor em caixa (double ou decimal)
- Lista de alunos (lista de objeto de aluno)

O aluno deve ter:

- Nome (string)
- CPF (string)
- Status pagamento (Enum status pagamento (pago = 0, a pagar = 1))
- Data de nascimento

Ao iniciar o programa, o usuário deve preencher os dados da academia e depois fazer a gerência dos alunos.

## Funcionalidades

O sistema deve efetuar as seguintes operações:

1. **Cadastrar um aluno:** Você deve validar se há vagas disponíveis na academia e se o CPF já está cadastrado no sistema. Perguntar se o aluno deseja efetuar o pagamento; se efetuar, deve alterar o status pagamento para pago e adicionar o valor ao caixa da academia.
2. **Efetuar pagamento:** Você deve procurar o aluno pelo CPF, verificar se ele já está com o status pago, se não estiver, receber o dinheiro, alterar o status para pago e adicionar o valor ao caixa da academia.
3. **Cancelar aluno da academia:** Você deve procurar o aluno pelo CPF e remover o aluno da lista de alunos, desde que ele esteja com o status pago.

Utilize exceptions que façam sentido nas validações.

## To Do

- [x] criar gitignore
- [ ] remover codigo comentado das exceptions movidas 
- [ ] Revisar e padronizar nomeclaturas
- [ ] Criar testes 
