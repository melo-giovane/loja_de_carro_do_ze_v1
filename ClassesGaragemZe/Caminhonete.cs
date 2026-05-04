namespace ClassesGaragemZe;
public class Caminhonete : DeCarga
{
    public string TipoCabine { get; set; }

    public Caminhonete(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, decimal capacidadeCarga, string tipoCabine)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadeCarga)
    {
        TipoCabine = tipoCabine;
    }
}
