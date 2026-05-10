namespace ClassesGaragemZe
{
    public class Revenda
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Revenda(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Revenda: {Nome}, Endereço: {Endereco}, Telefone: {Telefone}";
        }
    }
}