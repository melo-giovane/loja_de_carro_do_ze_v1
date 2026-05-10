namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public class Utilitarios : DeMisto
{
    public string Tracao { get; set; }

    public Utilitarios(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos, decimal capacidadeCarga, int capacidadePassageiros, string tracao)
        : base(marca, modelo, cor, anoFabricacao, anoModelo, combustivel, cavalos, kmRodados, valorPago, valorDeVenda, valorCustos, capacidadeCarga, capacidadePassageiros)
    {
        Tracao = tracao;
    }
}