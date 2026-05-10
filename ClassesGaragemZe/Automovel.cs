namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public class Automovel : DePassageiros
{
    public int NumeroPortas { get; set; }

    public Automovel(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, int numeroPortas, int capacidadePassageiros)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadePassageiros)
    {
        NumeroPortas = numeroPortas;
        CapacidadePassageiros = capacidadePassageiros;
    }
}