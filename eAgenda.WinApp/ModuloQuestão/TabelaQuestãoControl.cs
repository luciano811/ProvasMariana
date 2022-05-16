using eAgenda.Dominio.ModuloQuestao;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.Moduloquestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"}
           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Questao> questões)
        {
            grid.Rows.Clear();

            foreach (Questao Questao in questões)
            {
                grid.Rows.Add(Questao.Numero, Questao.Enunciado, Questao.Disciplina, Questao.Materia);
            }
        }

        internal int ObtemNumeroquestaoSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
