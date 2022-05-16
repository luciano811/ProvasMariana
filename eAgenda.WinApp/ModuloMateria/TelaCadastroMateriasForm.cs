using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriasForm : Form
    {
        public TelaCadastroMateriasForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            CarregarSeriesMateria();

            CarregarDisciplinas(disciplinas);


        }


        private void CarregarSeriesMateria()
        {
            var series = Enum.GetValues(typeof(SerieMateriaEnum));

            foreach (var item in series)
            {
                cmbSeries.Items.Add(item);
            }
        }

        void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinas.Items.Add(item);
            }
        }
        private Materia materia;

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;

                txtNumero.Text = materia.Numero.ToString();
                txtDescricao.Text = materia.Descricao;
                cmbDisciplinas.SelectedItem = materia.Disciplina;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            materia.Descricao = txtDescricao.Text;
            materia.Disciplina = (Disciplina)cmbDisciplinas.SelectedItem;
            materia.SerieMateria = (SerieMateriaEnum)cmbSeries.SelectedItem;


            ValidationResult resultadoValidacao = GravarRegistro(materia);

            if (resultadoValidacao.IsValid == false)
            {
                string primeiroErro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        
    }
}
