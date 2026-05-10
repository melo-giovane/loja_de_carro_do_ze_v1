using ClassesGaragemZe;
using System.Collections.Generic;

namespace AplicacaoGaragemDoZe
{
    public class Adicionar_Veiculo
    {
        public static void CadastrarVeiculo(List<Veiculo> frota)
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("                CADASTRO DE VEÍCULO               ");
            Console.WriteLine("==================================================");

            Console.WriteLine("Escolha a categoria principal do veículo:");
            Console.WriteLine("1. Passeio (Carros, Motos, Bicicletas, Etc.)");
            Console.WriteLine("2. Carga (Caminhões, Caminhonetes, Etc.)");
            Console.WriteLine("3. Misto (Utilitários)");
            Console.Write("Opção de Categoria: ");

            if (!int.TryParse(Console.ReadLine(), out int categoriaEscolhida) || categoriaEscolhida < 1 || categoriaEscolhida > 3)
            {
                Console.WriteLine("Opção inválida! O cadastro foi cancelado.");
                return;
            }

            Veiculo novoVeiculo = null;

            try
            {
                Console.Write("Marca: ");
                string marca = Console.ReadLine() ?? "";
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine() ?? "";
                Console.Write("Cor: ");
                string cor = Console.ReadLine() ?? "";
                Console.Write("Ano de Fabricação: ");
                int anoFabricacao = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Ano do Modelo: ");
                int anoModelo = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Combustível: ");
                string combustivel = Console.ReadLine() ?? "";
                Console.Write("Cavalos: ");
                int cavalos = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Km Rodados: ");
                int kmRodados = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Valor Pago: ");
                decimal valorPago = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Valor de Venda: ");
                decimal valorDeVenda = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Valor de Custos (opcional): ");
                decimal valorCustos = decimal.Parse(Console.ReadLine() ?? "0");

                switch (categoriaEscolhida)
                {
                    case 1: // DePassageiros
                        Console.Write("Capacidade de Passageiros: ");
                        int capacidadePassageiros = int.Parse(Console.ReadLine() ?? "0");
                        novoVeiculo = new DePassageiros(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadePassageiros);
                        break;
                    case 2: // DeCarga
                        Console.Write("Capacidade de Carga (Kg): ");
                        decimal capacidadeCargaKg = decimal.Parse(Console.ReadLine() ?? "0");
                        novoVeiculo = new DeCarga(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadeCargaKg);
                        break;
                    case 3: // DeMisto (Utilitários)
                        Console.Write("Capacidade de Carga (Kg): ");
                        decimal capCarga = decimal.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Capacidade de Passageiros: ");
                        int capPassageiros = int.Parse(Console.ReadLine() ?? "0");
                        novoVeiculo = new DeMisto(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capCarga, capPassageiros);
                        break;
                }

                if (novoVeiculo != null)
                {
                    frota.Add(novoVeiculo);
                    Console.WriteLine("\nVeículo cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro durante o cadastro: {ex.Message}");
            }
        }
    }
}