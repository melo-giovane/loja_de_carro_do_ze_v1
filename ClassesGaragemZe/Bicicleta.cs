namespace ClassesGaragemZe;
public class Bicicleta : DePassageiros
{
    public int Aro { get; set; }
    public int Marchas { get; set; }

    public Bicicleta(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, int capacidadePassageiros, int aro, int marchas)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadePassageiros)
    {
        Aro = aro;
        Marchas = marchas;
    }
}