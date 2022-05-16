using eAgenda.Dominio.ModuloMateria;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloMateria
{
    public partial class TabelaMateriasControl : UserControl
    {
        public TabelaMateriasControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série"}
           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Materia> materias)
        {
            grid.Rows.Clear();

            foreach (Materia materia in materias)
            {
                grid.Rows.Add(materia.Numero, materia.Descricao, materia.Disciplina, materia.SerieMateria);
            }
        }

        internal int ObtemNumeroMateriaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
