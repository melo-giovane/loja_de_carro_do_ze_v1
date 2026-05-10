namespace ClassesGaragemZe //Giovane Melo, Gustavo Decker Couto
{
    public class Revenda
    {
        public string Nome { get; set; } // ENCAPSULAMENTO - PROPRIEDADES COM GETTERS E SETTERS
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Revenda(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString() // POLIMORFISMO: Sobrescreve o método ToString para exibir os dados da revenda de forma personalizada
        {
            return $"Revenda: {Nome}, Endereço: {Endereco}, Telefone: {Telefone}";
        }
    }
}