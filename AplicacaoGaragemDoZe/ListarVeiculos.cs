using ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto
using System.Collections.Generic;
using System.Linq;

namespace AplicacaoGaragemDoZe
{
    public class ListarVeiculos
    {
        public static void ExibirMenuListagem(List<Veiculo> frota)
        {
            while (true)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("            LISTAR VEÍCULOS POR CATEGORIA         ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Automóveis");
                Console.WriteLine("2. Motocicletas");
                Console.WriteLine("3. Bicicletas");
                Console.WriteLine("4. Caminhões");
                Console.WriteLine("5. Caminhonetes");
                Console.WriteLine("6. Utilitários");
                Console.WriteLine("7. Todos os Veículos");
                Console.WriteLine("0. Voltar ao Menu");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        ListarAutomoveis(frota);
                        break;
                    case 2:
                        ListarMotocicletas(frota);
                        break;
                    case 3:
                        ListarBicicletas(frota);
                        break;
                    case 4:
                        ListarCaminhoes(frota);
                        break;
                    case 5:
                        ListarCaminhonetes(frota);
                        break;
                    case 6:
                        ListarUtilitarios(frota);
                        break;
                    case 7:
                        ListarTodos(frota);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void ListarAutomoveis(List<Veiculo> frota)
        {
            var automoveis = frota.OfType<Automovel>().ToList();
            if (automoveis.Count == 0)
            {
                Console.WriteLine("\nNenhum automóvel cadastrado.");
                return;
            }

            Console.WriteLine($"\n==== AUTOMÓVEIS ({automoveis.Count}) ====");
            for (int i = 0; i < automoveis.Count; i++)
            {
                var auto = automoveis[i];
                Console.WriteLine($"\n{i + 1}. {auto.Marca} {auto.Modelo}");
                Console.WriteLine($"   Cor: {auto.Cor} | Ano: {auto.AnoModelo}");
                Console.WriteLine($"   Combustível: {auto.Combustivel} | Cavalos: {auto.Cavalos}");
                Console.WriteLine($"   Km: {auto.KmRodados} | Portas: {auto.NumeroPortas}");
                Console.WriteLine($"   Capacidade: {auto.CapacidadePassageiros} passageiros");
                Console.WriteLine($"   Valor: R$ {auto.ValorDeVenda:F2}");
            }
        }

        private static void ListarMotocicletas(List<Veiculo> frota)
        {
            var motos = frota.OfType<Motocicleta>().ToList();
            if (motos.Count == 0)
            {
                Console.WriteLine("\nNenhuma motocicleta cadastrada.");
                return;
            }

            Console.WriteLine($"\n==== MOTOCICLETAS ({motos.Count}) ====");
            for (int i = 0; i < motos.Count; i++)
            {
                var moto = motos[i];
                Console.WriteLine($"\n{i + 1}. {moto.Marca} {moto.Modelo}");
                Console.WriteLine($"   Cor: {moto.Cor} | Ano: {moto.AnoModelo}");
                Console.WriteLine($"   Combustível: {moto.Combustivel} | Cavalos: {moto.Cavalos}");
                Console.WriteLine($"   Cilindrada: {moto.Cilindrada} cc | Km: {moto.KmRodados}");
                Console.WriteLine($"   Capacidade: {moto.CapacidadePassageiros} passageiros");
                Console.WriteLine($"   Valor: R$ {moto.ValorDeVenda:F2}");
            }
        }

        private static void ListarBicicletas(List<Veiculo> frota)
        {
            var bicicletas = frota.OfType<Bicicleta>().ToList();
            if (bicicletas.Count == 0)
            {
                Console.WriteLine("\nNenhuma bicicleta cadastrada.");
                return;
            }

            Console.WriteLine($"\n==== BICICLETAS ({bicicletas.Count}) ====");
            for (int i = 0; i < bicicletas.Count; i++)
            {
                var bike = bicicletas[i];
                Console.WriteLine($"\n{i + 1}. {bike.Marca} {bike.Modelo}");
                Console.WriteLine($"   Cor: {bike.Cor} | Ano: {bike.AnoModelo}");
                Console.WriteLine($"   Aro: {bike.Aro}\" | Marchas: {bike.Marchas}");
                Console.WriteLine($"   Km: {bike.KmRodados}");
                Console.WriteLine($"   Valor: R$ {bike.ValorDeVenda:F2}");
            }
        }

        private static void ListarCaminhoes(List<Veiculo> frota)
        {
            var caminhoes = frota.OfType<Caminhao>().ToList();
            if (caminhoes.Count == 0)
            {
                Console.WriteLine("\nNenhum caminhão cadastrado.");
                return;
            }

            Console.WriteLine($"\n==== CAMINHÕES ({caminhoes.Count}) ====");
            for (int i = 0; i < caminhoes.Count; i++)
            {
                var cam = caminhoes[i];
                Console.WriteLine($"\n{i + 1}. {cam.Marca} {cam.Modelo}");
                Console.WriteLine($"   Cor: {cam.Cor} | Ano: {cam.AnoModelo}");
                Console.WriteLine($"   Combustível: {cam.Combustivel} | Cavalos: {cam.Cavalos}");
                Console.WriteLine($"   Carga: {cam.CapacidadeCargaKg} kg | Eixos: {cam.NumeroEixos}");
                Console.WriteLine($"   Km: {cam.KmRodados}");
                Console.WriteLine($"   Valor: R$ {cam.ValorDeVenda:F2}");
            }
        }

        private static void ListarCaminhonetes(List<Veiculo> frota)
        {
            var caminhonetes = frota.OfType<Caminhonete>().ToList();
            if (caminhonetes.Count == 0)
            {
                Console.WriteLine("\nNenhuma caminhonete cadastrada.");
                return;
            }

            Console.WriteLine($"\n==== CAMINHONETES ({caminhonetes.Count}) ====");
            for (int i = 0; i < caminhonetes.Count; i++)
            {
                var cami = caminhonetes[i];
                Console.WriteLine($"\n{i + 1}. {cami.Marca} {cami.Modelo}");
                Console.WriteLine($"   Cor: {cami.Cor} | Ano: {cami.AnoModelo}");
                Console.WriteLine($"   Combustível: {cami.Combustivel} | Cavalos: {cami.Cavalos}");
                Console.WriteLine($"   Carga: {cami.CapacidadeCargaKg} kg | Cabine: {cami.TipoCabine}");
                Console.WriteLine($"   Km: {cami.KmRodados}");
                Console.WriteLine($"   Valor: R$ {cami.ValorDeVenda:F2}");
            }
        }

        private static void ListarUtilitarios(List<Veiculo> frota)
        {
            var utilitarios = frota.OfType<Utilitarios>().ToList();
            if (utilitarios.Count == 0)
            {
                Console.WriteLine("\nNenhum utilitário cadastrado.");
                return;
            }

            Console.WriteLine($"\n==== UTILITÁRIOS ({utilitarios.Count}) ====");
            for (int i = 0; i < utilitarios.Count; i++)
            {
                var util = utilitarios[i];
                Console.WriteLine($"\n{i + 1}. {util.Marca} {util.Modelo}");
                Console.WriteLine($"   Cor: {util.Cor} | Ano: {util.AnoModelo}");
                Console.WriteLine($"   Combustível: {util.Combustivel} | Cavalos: {util.Cavalos}");
                Console.WriteLine($"   Tração: {util.Tracao}");
                Console.WriteLine($"   Carga: {util.CapacidadeCargaKg} kg | Passageiros: {util.CapacidadePassageiros}");
                Console.WriteLine($"   Km: {util.KmRodados}");
                Console.WriteLine($"   Valor: R$ {util.ValorDeVenda:F2}");
            }
        }

        public static void ListarTodos(List<Veiculo> frota)
        {
            if (frota.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine($"\n==== TODOS OS VEÍCULOS ({frota.Count}) ====");
            for (int i = 0; i < frota.Count; i++)
            {
                var veiculo = frota[i];
                Console.WriteLine($"\n{i + 1}. [{veiculo.GetType().Name}] {veiculo.Marca} {veiculo.Modelo}");
                Console.WriteLine($"   Cor: {veiculo.Cor} | Ano: {veiculo.AnoModelo}");
                Console.WriteLine($"   Combustível: {veiculo.Combustivel} | Cavalos: {veiculo.Cavalos}");
                Console.WriteLine($"   Km: {veiculo.KmRodados}");
                Console.WriteLine($"   Valor: R$ {veiculo.ValorDeVenda:F2}");
            }
        }
    }
}
