using ClassesGaragemZe;
namespace AplicacaoGaragemDoZe;

public abstract class Menu
{
    public static string[] Categorias = { "Automóvel", "Bicicleta", "Caminhão", "Caminhonete", "De Carga", "De Passageiros", "Motocicleta", "Utilitário", };
    public static string[] Opcoes = { "Adicionar Veículo", "Listar Veículos", "Listar Categorias", "Sair" };


    public static Type seletorDeTipo(int categoria)
    {
        switch (categoria)
        {
            case 1: return typeof(Automovel);
            case 2: return typeof(Bicicleta);
            case 3: return typeof(Caminhao);
            case 4: return typeof(Caminhonete);
            case 5: return typeof(DeCarga);
            case 6: return typeof(DePassageiros);
            case 7: return typeof(Motocicleta);
            case 8: return typeof(Utilitarios);
            default:
                throw new ArgumentException("Categoria inválida");

        }
    }

}