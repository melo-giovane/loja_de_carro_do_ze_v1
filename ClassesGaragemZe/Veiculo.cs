namespace ClassesGaragemZe; //Giovane Melo, Gustavo Decker Couto

public abstract class Veiculo
{
    public string Marca { get; init; }
    public string Modelo { get; init; }
    public string Cor { get; init; }
    public int AnoFabricacao { get; init; }
    public int AnoModelo { get; init; }
    public string Combustivel { get; init; }
    public int Cavalos { get; init; }
    public int KmRodados { get; init; }
    public decimal ValorPago { get; init; }
    public decimal ValorCustos { get; init; }
    public decimal ValorDeVenda { get; init; }


    public Veiculo(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int cavalos, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos = 0)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        AnoFabricacao = anoFabricacao;
        AnoModelo = anoModelo;
        Combustivel = combustivel;
        Cavalos = cavalos;
        KmRodados = kmRodados;
        ValorPago = valorPago;
        ValorCustos = valorCustos;
        ValorDeVenda = valorDeVenda;
    }

}