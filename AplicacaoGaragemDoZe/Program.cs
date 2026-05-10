namespace AplicacaoGaragemDoZe;

using ClassesGaragemZe;
using System;
using System.Collections.Generic;

internal class Program
{
    public Program()
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        Console.WriteLine("Bem-vindo à Garagem do Zé!");
        while (true)
        {
        Console.WriteLine("Selecione uma opção:");
        for (int i = 0; i < Menu.Opcoes.Length; i++)
        {
            Console.WriteLine(Menu.Opcoes[i]);
        }
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: // Adicionar Veículo
                Console.WriteLine("Escolha a categoria do veículo:");
                for (int i = 0; i < Menu.Categorias.Length; i++)
                {
                    Console.WriteLine(Menu.Categorias[i]);
                }
                int categoria = int.Parse(Console.ReadLine());
                Type tipo = Menu.seletorDeTipo(categoria);
                



            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                continue;
        }
        }


    }
}
