using System;
using ClassesGaragemZe;

namespace AplicacaoGaragemDoZe
{
    public abstract class Menu // ABSTRAÇÂO - CLASSE ABSTRATA, NÃO PODE SER INSTANCIADA, SERVE APENAS COMO BASE PARA OUTRAS CLASSES
    {
        public static string[] Categorias = { "Passeio", "Transporte", "Carga", "Misto" };
        public static string[] Subcategorias = { "Automóvel", "Bicicleta", "Caminhão", "Caminhonete", "Motocicleta", "Utilitários" };

        public static string[] Opcoes = {
            "Cadastrar Dados da Revenda",
            "Adicionar Veículo",
            "Listar Veículos por Categoria",
            "Listar Dados da Revenda",
            "Sair"
        };

        public static Type seletorDeTipo(int categoria)
        {
            switch (categoria)
            {
                case 1: return typeof(DePassageiros);
                case 2: return typeof(DeMisto);
                case 3: return typeof(DeCarga);
                case 4: return typeof(Utilitarios);
                default:
                    throw new ArgumentException("Categoria inválida");
            }
        }
    }
}