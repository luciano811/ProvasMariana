using eAgenda.Dominio.Compartilhado;
using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio.ModuloProva
{
    [Serializable]
    public class Prova : EntidadeBase<Prova>
    {
        public string Conteudo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public DateTime DataProva { get; set; }
        public List<Questao> Questoes { get; set; }
        public int NumQuestoes { get; set; }

        public Prova()
        {
            DataProva = DateTime.Now;
        }

        public Prova(Prova registro)
        {
            Conteudo = registro.Conteudo;
            Disciplina = registro.Disciplina;
            Materia = registro.Materia;
            DataProva = DateTime.Now;
            Questoes = registro.Questoes;
            NumQuestoes = registro.NumQuestoes;
        }
        public override void Atualizar(Prova registro)
        {
            Conteudo = registro.Conteudo;
            Disciplina = registro.Disciplina;
            Materia = registro.Materia;
            DataProva = registro.DataProva;
            Questoes = registro.Questoes;
            NumQuestoes = registro.NumQuestoes;
        }

    }
}
