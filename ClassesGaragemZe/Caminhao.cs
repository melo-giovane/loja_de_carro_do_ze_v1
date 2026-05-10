namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public class Caminhao : DeCarga
{
    public int NumeroEixos { get; set; }

    public Caminhao(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, decimal capacidadeCarga, int numeroEixos)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadeCarga)
    {
        NumeroEixos = numeroEixos;
    }
}