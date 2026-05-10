namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public class Motocicleta : DePassageiros
{
    public decimal Cilindrada { get; set; }

    public Motocicleta(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, int capacidadePassageiros, decimal cilindrada)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadePassageiros)
    {
        Cilindrada = cilindrada;
    }
}