// ================================================================================
// PARTICIPANTES: [Insira o Nome do Aluno 1], [Aluno 2], [Aluno 3], [Aluno 4]
// ================================================================================

using System;
using ClassesGaragemZe;

namespace AplicacaoGaragemDoZe
{
    public abstract class Menu
    {
        public static string[] Categorias = { "Passeio", "Transporte", "Carga", "Misto" };
        public static string[] Subcategorias = { "Automóvel", "Bicicleta", "Caminhão", "Caminhonete", "Motocicleta", "Utilitários" };

        public static string[] Opcoes = {
            "Cadastrar Dados da Revenda",
            "Adicionar Veículo",
            "Listar Dados da Revenda",
            "Listar todos os dados de revendas (Revenda e seus Veículos)",
            "Listar Somente uma Categoria Específica de Veículo",
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