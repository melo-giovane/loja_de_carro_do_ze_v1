namespace ClassesGaragemZe;

public abstract class DePassageiro : Veiculo
{
    public string CapacidadePessoas { get; set; }

    public DePassageiro(string marca, string modelo, string cor, int ano, int portas, string combustivel, int cilindrada, decimal precoCusto, decimal margemLucro, decimal precoVenda, string capacidadePessoas)
        : base(marca, modelo, cor, ano, portas, combustivel, cilindrada, precoCusto, margemLucro, precoVenda)
    {
        CapacidadePessoas = capacidadePessoas;
    }
}