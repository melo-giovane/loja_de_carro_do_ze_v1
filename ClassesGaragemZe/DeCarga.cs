namespace ClassesGaragemZe;
public class DeCarga : Veiculo
{
    public decimal CapacidadeCargaKg { get; set; }

    public DeCarga(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, decimal capacidadeCarga)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos)
    {
        CapacidadeCargaKg = capacidadeCarga;
    }
}