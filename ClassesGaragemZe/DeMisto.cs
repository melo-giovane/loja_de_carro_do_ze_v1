namespace ClassesGaragemZe;
public class DeMisto : Veiculo
{
    public decimal CapacidadeCargaKg { get; set; }
    public int CapacidadePassageiros { get; set; }

    public DeMisto(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, decimal capacidadeCargaKg, int capacidadePassageiros)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos)
    {
        CapacidadeCargaKg = capacidadeCargaKg;
        CapacidadePassageiros = capacidadePassageiros;
    }
}