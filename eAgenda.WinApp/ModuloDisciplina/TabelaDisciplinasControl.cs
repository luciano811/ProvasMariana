using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.WinApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinasControl : UserControl
    {
        public TabelaDisciplinasControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Numero"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto"},

            };

            return colunas;
        }

        public int ObtemNumeroDisciplinaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();

            foreach (var disciplina in disciplinas)
            {
                grid.Rows.Add(disciplina.Numero, disciplina.Assunto);
            }
        }

    }
}
