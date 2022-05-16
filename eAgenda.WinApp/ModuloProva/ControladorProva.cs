using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.Dominio.ModuloProva;
using eAgenda.Dominio.ModuloQuestao;
using eAgenda.WinApp.Compartilhado;
using ProvasMariana.WinApp.ModuloProva;
using System.Collections.Generic;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using iTextSharp.text.pdf.draw;

namespace eAgenda.WinApp.ModuloProva
{
    public class ControladorProva : ControladorBase
    {
        private IRepositorioProva repositorioProva;
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private TabelaProvasControl tabelaProvas;


        public ControladorProva(IRepositorioProva repositorioProva, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioProva = repositorioProva;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroProvasForm tela = new TelaCadastroProvasForm(disciplinas, materias, repositorioQuestao );
            tela.Prova = new Prova();

            tela.GravarRegistro = repositorioProva.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarProvas();
            }
        }
        public  void GerarPdf()
        {
            //Prova provaSelecionada = ObtemProvaSelecionado();
            //string provaDaMariana = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\provaDaMariana.pdf";

            //Document document = new Document(PageSize.A4);
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(provaDaMariana, FileMode.Create, FileAccess.ReadWrite));
            //document.Open();

            //Font times = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);

            //Paragraph tituloProva = new Paragraph(provaSelecionada.Conteudo, times);
            //tituloProva.Alignment = Element.ALIGN_CENTER;
            //Chunk glue = new Chunk(new VerticalPositionMark());
            //Paragraph informacoesProva = new Paragraph($"Disciplina: {provaSelecionada.Disciplina.Assunto}", times);
            //informacoesProva.Add(new Chunk(glue));
            //informacoesProva.Add($"Matéria: {provaSelecionada.Materia.Descricao}");

            //document.Add(tituloProva);
            //document.Add(informacoesProva);

            //for (int i = 0; i < provaSelecionada.Questoes.Count; i++)
            //{
            //    Paragraph questao = new Paragraph($"Questão {i + 1}: {provaSelecionada.Questoes[i].Enunciado}", times);
            //    document.Add(questao);
            //    foreach (var alternativa in provaSelecionada.Questoes[i].Alternativas)
            //    {
            //        Paragraph alternativaQuestao = new Paragraph($"{alternativa.Num}: {alternativa.Texto}", times);
            //        document.Add(alternativaQuestao);
            //    }
            //}

            //document.NewPage();
            //Paragraph gabarito = new Paragraph("Gabarito", times);
            //gabarito.Alignment = Element.ALIGN_CENTER;
            //document.Add(gabarito);

            //for (int i = 0; i < provaSelecionada.Questoes.Count; i++)
            //{
            //    Paragraph questao = new Paragraph($"Questão {i + 1}: {provaSelecionada.Questoes[i].Enunciado}", times);
            //    document.Add(questao);

            //    Alternativa alternativaCorreta;
            //    alternativaCorreta = provaSelecionada.Questoes[i].Alternativas.Find(x => x.Certa);

            //    Paragraph alternativaQuestao = new Paragraph($"{alternativaCorreta.Num}: {alternativaCorreta}", times);
            //    document.Add(alternativaQuestao);
            //}

            //document.Close();                                           

            //MessageBox.Show("PDF gerado com sucesso",
            //"Gerãção de PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //return;
        }

        private Prova ObtemProvaSelecionado()
        {
            var numero = tabelaProvas.ObtemNumeroProvaSelecionado();

            return repositorioProva.SelecionarPorNumero(numero);
        }

        private static PdfPCell CriarCelula(string enunciado)
        {
            var celula = new PdfPCell(new Phrase("Código"));

            return celula;
        }

        public override void Editar()
        {
            Prova provaSelecionada = ObtemProvaSelecionada();

            if (provaSelecionada == null)
            {
                MessageBox.Show("Selecione uma prova primeiro",
                "Edição de Provas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();
            TelaCadastroProvasForm tela = new TelaCadastroProvasForm(disciplinas, materias, repositorioQuestao);

            tela.Prova = provaSelecionada;

            tela.GravarRegistro = repositorioProva.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarProvas();
            }
        }

        public override void Excluir()
        {
            Prova provaSelecionada = ObtemProvaSelecionada();

            if (provaSelecionada == null)
            {
                MessageBox.Show("Selecione uma prova primeiro",
                "Exclusão de Provas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a prova?",
                "Exclusão de Provas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioProva.Excluir(provaSelecionada);
                CarregarProvas();
            }
        }

             

        public override UserControl ObtemListagem()
        {
            if (tabelaProvas == null)
                tabelaProvas = new TabelaProvasControl();

            CarregarProvas();

            return tabelaProvas;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxProva();
        }

        private void CarregarProvas()
        {
            List<Prova> provas = repositorioProva.SelecionarTodos();

            tabelaProvas.AtualizarRegistros(provas);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {provas.Count} prova(s)");
        }

        private Prova ObtemProvaSelecionada()
        {
            var numero = tabelaProvas.ObtemNumeroProvaSelecionado();

            return repositorioProva.SelecionarPorNumero(numero);
        }
    }
}
