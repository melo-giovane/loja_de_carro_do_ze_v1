namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public class DePassageiros : Veiculo
{
    public int CapacidadePassageiros { get; set; }

    public DePassageiros(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, int capacidadePassageiros)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos)
    {
        CapacidadePassageiros = capacidadePassageiros;
    }
}