namespace ClassesGaragemZe;

public abstract class Veiculo
{
    public required string Marca { get; set; }
    public required string Modelo { get; set; }
    public required string Cor { get; set; }
    public required int AnoFabricacao { get; set; }
    public required int AnoModelo { get; set; }
    public required string Combustivel { get; set; }
    public required int KmRodados { get; set; }
    public required decimal ValorPago { get; set; }
    public decimal ValorCustos { get; set; }
    public required decimal ValorDeVenda { get; set; }


    public Veiculo(string marca, string modelo, string cor, int anoFabricacao, int anoModelo, string combustivel, int kmRodados, decimal valorPago, decimal valorDeVenda, decimal valorCustos = 0)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        AnoFabricacao = anoFabricacao;
        AnoModelo = anoModelo;
        Combustivel = combustivel;
        KmRodados = kmRodados;
        ValorPago = valorPago;
        ValorCustos = valorCustos;
        ValorDeVenda = valorDeVenda;
    }

}