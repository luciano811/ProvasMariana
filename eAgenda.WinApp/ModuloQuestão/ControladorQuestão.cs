using eAgenda.Dominio.ModuloQuestao;
using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.Moduloquestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private readonly IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestões;


        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;

        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();


            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(disciplinas, materias);

            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestões.AtualizarRegistros(questoes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {questoes.Count} questões(s)");
        }

        public override void Editar()
        {
            Questao questaoSelecionada = ObtemquestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma Questao primeiro",
                    "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();



            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(disciplinas,materias);

            tela.Questao = questaoSelecionada;

            tela.GravarRegistro = repositorioQuestao.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemquestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma Questao primeiro",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Questao?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }
        }
      
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaQuestões == null)
                tabelaQuestões = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestões;
        }

        private Questao ObtemquestaoSelecionada()
        {
            int numeroSelecionado = tabelaQuestões.ObtemNumeroquestaoSelecionada();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorNumero(numeroSelecionado);

            return questaoSelecionada;
        }
    }
}
