using eAgenda.Dominio.ModuloDisciplina;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDisciplina
{
    public partial class TelaCadastroDisciplinasForm : Form
    {
        private Disciplina disciplina;

        public TelaCadastroDisciplinasForm()
        {
            InitializeComponent();

        }        

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set
            {
                disciplina = value;

                txtNumero.Text = disciplina.Numero.ToString();

                txtAssunto.Text = disciplina.Assunto;

                               



            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            disciplina.Assunto = txtAssunto.Text;                        
            

            

            var resultadoValidacao = GravarRegistro(disciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroDisciplinasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroCompromisssosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        
        
        
    }
}
