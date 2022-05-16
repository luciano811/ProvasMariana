using eAgenda.Dominio.ModuloQuestao;
using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp.Moduloquestao
{
    public partial class TelaCadastroQuestaoForm : Form
    {
        private Questao questao;
        public int contadorAlternativas = 0;
        List<Alternativa> alternativasAdicionadas = new List<Alternativa>();
        public TelaCadastroQuestaoForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();

            CarregarDisciplinas(disciplinas);

            CarregarMaterias(materias);

        }

        private void CarregarMaterias(List<Materia> materias)
        {
            cmbMateriaQuestao.Items.Clear();


            foreach (var item in materias)
            {
                cmbMateriaQuestao.Items.Add(item);
            }
        }

        void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinaQuestao.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinaQuestao.Items.Add(item);
            }
        }


        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get
            {
                return questao;
            }
            set
            {
                questao = value;

                txtNumero.Text = Questao.Numero.ToString();
                txtEnunciadoQuestao.Text = Questao.Enunciado;
                cmbMateriaQuestao.SelectedItem = Questao.Disciplina;
                cmbDisciplinaQuestao.SelectedItem = Questao.Materia;
            }
        }
        public List<Alternativa> Alternativas
        {
            get
            {
                return listAlternativasQuestao.Items.Cast<Alternativa>().ToList();
            }
        }
        private void btnInserirAlternativa_Click(object sender, EventArgs e)
        {
            txtEnunciadoQuestao.Enabled = false;


            if (String.IsNullOrEmpty(txtAlternativaQuestao.Text) || String.IsNullOrEmpty(txtEnunciadoQuestao.Text))
            {
                string erro = "Não pode inserir com campos vazios";
                TelaPrincipalForm.Instancia.AtualizarRodape(erro);
                DialogResult = DialogResult.None;
            }
            else
            {
                Alternativa alternativa = new Alternativa();
                alternativa.Num = contadorAlternativas;
                contadorAlternativas++;

                alternativa.Texto = txtAlternativaQuestao.Text;
                if (btnEhCerta.Checked)
                {
                    alternativa.Certa = true;
                    listAlternativasQuestao.Items.Add($"{alternativa.Num}) {alternativa.Texto} ✔");
                }
                else
                {
                    listAlternativasQuestao.Items.Add($"{alternativa.Num}) {alternativa.Texto}");
                }

                alternativasAdicionadas.Add(alternativa);
                btnEhCerta.Checked = false;
                cmbDisciplinaQuestao.Enabled = false;
                cmbMateriaQuestao.Enabled = false;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Questao.Enunciado = txtEnunciadoQuestao.Text;
            Questao.Disciplina = (Disciplina)cmbDisciplinaQuestao.SelectedItem;
            Questao.Materia = (Materia)cmbMateriaQuestao.SelectedItem;
            questao.Alternativas = alternativasAdicionadas;


            ValidationResult resultadoValidacao = GravarRegistro(Questao);

            if (resultadoValidacao.IsValid == false)
            {
                string primeiroErro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        
    }
}
