namespace AplicacaoGaragemDoZe;

using ClassesGaragemZe;
using System;
using System.Collections.Generic;

internal class Program
{    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();
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

                case 3: // Listar Veículos
                    Console.WriteLine();
                    if (veiculos.Count == 0)
                    {
                        Console.WriteLine("Nenhum veículo cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Veículos cadastrados:");
                        foreach (var veiculo in veiculos)
                        {
                            Console.WriteLine(veiculo);
                        }
                    }
                    break;

                case 4: // Listar Categorias
                    Console.WriteLine("\nCategorias disponíveis:");
                    foreach (var cat in Menu.Categorias)
                    {
                        Console.WriteLine(cat);
                    }
                    break;
                case 5: // Listar Subcategorias
                    Console.WriteLine("\nSubcategorias disponíveis:");
                    foreach (var subcat in Menu.Subcategorias)
                    {
                        Console.WriteLine(subcat);
                    }
                    break;

                case 6: // Sair
                    Console.WriteLine("\nObrigado por usar a Garagem do Zé! Até mais!");
                    return; // Sai do Main, encerrando o programa

                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    break; // 'break' é mais limpo aqui do que 'continue'
            }
        }
    }
}