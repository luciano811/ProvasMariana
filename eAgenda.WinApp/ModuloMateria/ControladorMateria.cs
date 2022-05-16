using eAgenda.Dominio.ModuloMateria;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eAgenda.Dominio.ModuloDisciplina;

namespace eAgenda.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private readonly IRepositorioMateria repositorioMateria;
        private TabelaMateriasControl tabelaMaterias;


        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm(disciplinas);

            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(materias);
        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma materia primeiro",
                    "Edição de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm(disciplinas);

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma materia primeiro",
                "Exclusão de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a materia?",
                "Exclusão de Materias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }
      
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new TabelaMateriasControl();

            CarregarMaterias();

            return tabelaMaterias;
        }

        private Materia ObtemMateriaSelecionada()
        {
            int numeroSelecionado = tabelaMaterias.ObtemNumeroMateriaSelecionada();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorNumero(numeroSelecionado);

            return materiaSelecionada;
        }
    }
}
