using ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto
using System.Collections.Generic;

namespace AplicacaoGaragemDoZe
{
    public class Adicionar_Veiculo
    {
        // CARGA INICIAL / CADASTROS OBRIGATÓRIOS SIMPLIFICADOS
        public static void InserirVeiculosDeTeste(List<Veiculo> frota)
        {
            // Automóveis (DePassageiros com portas)
            frota.Add(new Automovel("Chevrolet", "Onix", "Preto", 2022, 2023, "Flex", 116, 25000, 70000m, 82000m, 1500m, 4, 5));
            frota.Add(new Automovel("Toyota", "Corolla", "Branco", 2023, 2024, "Híbrido", 122, 10000, 150000m, 175000m, 2000m, 4, 5));

            // Motocicletas (DePassageiros com cilindrada)
            frota.Add(new Motocicleta("Honda", "CG 160 Titan", "Vermelho", 2024, 2024, "Flex", 15, 5000, 16000m, 19500m, 500m, 2, 160));
            frota.Add(new Motocicleta("Yamaha", "MT-07", "Azul", 2023, 2023, "Gasolina", 74, 12000, 45000m, 52000m, 1200m, 2, 689));

            // Bicicletas (DePassageiros com aro e marchas)
            frota.Add(new Bicicleta("Caloi", "Elite Carbon", "Cinza", 2023, 2023, "Nenhum (Humano)", 1, 500, 8000m, 11000m, 300m, 1, 29, 24));
            frota.Add(new Bicicleta("Sense", "Intense", "Verde", 2024, 2024, "Nenhum (Humano)", 1, 100, 3500m, 4800m, 150m, 1, 29, 21));

            // Caminhões (DeCarga com eixos)
            frota.Add(new Caminhao("Volvo", "FH 540", "Branco", 2022, 2022, "Diesel", 540, 180000, 550000m, 620000m, 15000m, 35000m, 3));
            frota.Add(new Caminhao("Scania", "R 450", "Vermelho", 2021, 2021, "Diesel", 450, 220000, 480000m, 540000m, 12000m, 30000m, 3));

            // Caminhonetes (DeCarga com tipo de cabine)
            frota.Add(new Caminhonete("Toyota", "Hilux", "Prata", 2023, 2023, "Diesel", 204, 30000, 240000m, 270000m, 4000m, 1000m, "Dupla"));
            frota.Add(new Caminhonete("Ford", "Ranger", "Azul", 2024, 2024, "Diesel", 250, 8000, 260000m, 295000m, 3500m, 1050m, "Simples"));

            // Utilitários (DeMisto com tração)
            frota.Add(new Utilitarios("Fiat", "Toro", "Bordô", 2023, 2024, "Flex", 185, 15000, 130000m, 155000m, 3000m, 1000m, 5, "4x4"));
            frota.Add(new Utilitarios("Renault", "Oroch", "Verde", 2022, 2023, "Flex", 170, 40000, 95000m, 112000m, 2500m, 680m, 5, "4x2"));

            Console.WriteLine("\n[CARGA INICIAL: 12 veículos de teste foram inseridos automaticamente no pátio!]");
        }
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