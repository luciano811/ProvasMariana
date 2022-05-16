using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.Dominio.ModuloProva;
using eAgenda.Dominio.ModuloQuestao;
using eAgenda.WinApp;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvasMariana.WinApp.ModuloProva
{
    public partial class TelaCadastroProvasForm : Form
    {
        private Prova prova;
        private IRepositorioQuestao repositorioQuestao;
        List<Questao> questoesProva = new List<Questao>();



        public TelaCadastroProvasForm(List<Disciplina> disciplinas, List<Materia> materias, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;

            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);

        }

        private void CarregarMaterias(List<Materia> materias)
        {
            cmbMateriaQuestaoProva.Items.Clear();


            foreach (var item in materias)
            {
                cmbMateriaQuestaoProva.Items.Add(item);
            }
        }

        void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinaQuestaoProva.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinaQuestaoProva.Items.Add(item);
            }
        }

        public Func<Prova, ValidationResult> GravarRegistro { get; set; }

        public Prova Prova
        {
            get
            {
                return prova;
            }
            set
            {
                prova = value;
                txtNumero.Text = prova.Numero.ToString();
                txtConteudo.Text = prova.Conteudo;
                cmbDisciplinaQuestaoProva.SelectedItem = prova.Disciplina;
                cmbMateriaQuestaoProva.SelectedItem = prova.Materia;
                dateData.Value = prova.DataProva;
                txtQuantidadeQuestoes.Text = prova.NumQuestoes.ToString();
            }
        }

        private void btnGravarProva_Click(object sender, EventArgs e)
        {
            prova.Conteudo = txtConteudo.Text;
            prova.Disciplina = (Disciplina)cmbDisciplinaQuestaoProva.SelectedItem;
            prova.Materia = (Materia)cmbMateriaQuestaoProva.SelectedItem;
            prova.DataProva = dateData.Value;
            prova.NumQuestoes = int.Parse(txtQuantidadeQuestoes.Text);
            prova.Questoes = questoesProva;

            cmbDisciplinaQuestaoProva.SelectedItem = prova.Disciplina;
            cmbMateriaQuestaoProva.SelectedItem = prova.Materia;
            dateData.Value = prova.DataProva;
            txtQuantidadeQuestoes.Text = prova.NumQuestoes.ToString();

            var resultadoValidacao = GravarRegistro(prova);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroProvasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroProvasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        

        private void btnGravarQuestao_Click(object sender, EventArgs e)
        {
            listAlternativasQuestaoProva.Items.Clear();

            int countNumeroQuestao = 1;

            var questoes = repositorioQuestao.SelecionarTodos()
                            .Where(x => x.Disciplina.Assunto == cmbDisciplinaQuestaoProva.Text)
                            .Where(x => x.Materia.Descricao == cmbMateriaQuestaoProva.Text)
                            .ToList();

            var random = new Random();
            var questoesEmbaralhadas = questoes.OrderBy(item => random.Next()).ToList();
                                    
            for (int i = 0; i < int.Parse(txtQuantidadeQuestoes.Text); i++)
            {
                questoesProva.Add(questoesEmbaralhadas.ElementAt(i));
            }

            listAlternativasQuestaoProva.Items.Clear();

            foreach (var item in questoesProva)
            {
                listAlternativasQuestaoProva.Items.Add(countNumeroQuestao + "- " + item.ToString());
                countNumeroQuestao++;
            }
        }
    }
}

        
