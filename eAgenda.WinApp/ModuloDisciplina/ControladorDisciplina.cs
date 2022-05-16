using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaDisciplinasControl tabelaDisciplinas;
        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {

            TelaCadastroDisciplinasForm tela = new TelaCadastroDisciplinasForm();
            tela.Disciplina = new Disciplina();

            tela.GravarRegistro = repositorioDisciplina.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionado = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionado == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            TelaCadastroDisciplinasForm tela = new TelaCadastroDisciplinasForm();

            tela.Disciplina = disciplinaSelecionado;

            tela.GravarRegistro = repositorioDisciplina.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionado = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionado == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a disciplina?",
                "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplinaSelecionado);
                CarregarDisciplinas();
            }
        }

        
        public override UserControl ObtemListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaDisciplinasControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxDisciplina();
        }


        private Disciplina ObtemDisciplinaSelecionado()
        {
            var numero = tabelaDisciplinas.ObtemNumeroDisciplinaSelecionado();

            return repositorioDisciplina.SelecionarPorNumero(numero);
        }

        private void CarregarDisciplinasComFiltro(StatusDisciplinaEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoDisciplina;
            List<Disciplina> disciplinas;

            switch (statusSelecionado)
            {
                case StatusDisciplinaEnum.Futuros:
                    disciplinas = repositorioDisciplina.SelecionarDisciplinasFuturos(dataInicial, dataFinal);
                    tipoDisciplina = "futuro(s)"; 
                    break;

                case StatusDisciplinaEnum.Passados:
                    disciplinas = repositorioDisciplina.SelecionarDisciplinasPassados(DateTime.Now);
                    tipoDisciplina = "passado(s)";
                    break;

                default:
                    disciplinas = repositorioDisciplina.SelecionarTodos();
                    tipoDisciplina = ""; break;
            }

            tabelaDisciplinas.AtualizarRegistros(disciplinas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {disciplinas.Count} disciplina(s) {tipoDisciplina}");
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {disciplinas.Count} disciplina(s)");
        }
    }
}
