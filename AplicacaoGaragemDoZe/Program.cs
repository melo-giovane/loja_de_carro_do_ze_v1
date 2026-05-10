// ================================================================================
// PARTICIPANTES: [Insira o Nome do Aluno 1], [Aluno 2], [Aluno 3], [Aluno 4]
// ================================================================================

namespace AplicacaoGaragemDoZe;

using ClassesGaragemZe;
using System;
using System.Collections.Generic;

internal class Program
{    
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        
        // CHAMADA DIRETA: Insere 2 veículos de cada subcategoria automaticamente (Carga Inicial)
        Adicionar_Veiculo.InserirVeiculosDeTeste(veiculos);

        Console.WriteLine("Bem-vindo à Garagem do Zé!");

        while (true)
        {
            Console.WriteLine("\nSelecione uma opção:");
            for (int i = 0; i < Menu.Opcoes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu.Opcoes[i]}");
            }

            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
                continue;
            }

            switch (opcao)
            {
                case 1: // Cadastrar Dados da Revenda
                    Console.WriteLine("\nFuncionalidade de cadastro de revenda ainda não implementada.");
                    break;

                case 2:
                    Adicionar_Veiculo.CadastrarVeiculo(veiculos);
                    break;

                case 3: // Listar Veículos por Categoria
                    ListarVeiculos.ExibirMenuListagem(veiculos);
                    break;

                case 4: // Sair
                    Console.WriteLine("\nObrigado por usar a Garagem do Zé! Até mais!");
                    return;

                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break; 
            }
        }
    }
}