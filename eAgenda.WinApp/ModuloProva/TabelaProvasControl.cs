using eAgenda.Dominio.ModuloProva;
using eAgenda.WinApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloProva
{
    public partial class TabelaProvasControl : UserControl
    {
        public TabelaProvasControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Conteudo", HeaderText = "Conteúdo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

            };

            return colunas;
        }

        public int ObtemNumeroProvaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Prova> provas)
        {
            grid.Rows.Clear();

            foreach (Prova prova in provas)
            {
                grid.Rows.Add(prova.Numero, prova.Conteudo, prova.Disciplina, prova.Materia, prova.DataProva);
            }
        }


    }
}
