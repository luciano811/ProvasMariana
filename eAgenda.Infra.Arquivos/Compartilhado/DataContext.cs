using eAgenda.Dominio.ModuloQuestao;
using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.Dominio.ModuloProva;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos
{
    [Serializable]
    public class DataContext //Container
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Provas = new List<Prova>();

            Questões = new List<Questao>();


            Disciplinas = new List<Dominio.ModuloDisciplina.Disciplina>();

            Materias = new List<Dominio.ModuloMateria.Materia>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Prova> Provas { get; set; }

        public List<Questao> Questões { get; set; }

        public List<Dominio.ModuloDisciplina.Disciplina> Disciplinas { get; set; }

        public List<Dominio.ModuloMateria.Materia> Materias { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Provas.Any())
                this.Provas.AddRange(ctx.Provas);

            
            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);
        }
    }
}
