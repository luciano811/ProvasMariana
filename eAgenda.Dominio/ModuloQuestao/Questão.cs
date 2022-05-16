using eAgenda.Dominio.Compartilhado;
using eAgenda.Dominio.ModuloDisciplina;
using eAgenda.Dominio.ModuloMateria;
using eAgenda.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {        

        public string Enunciado { get; set; }

        public Disciplina Disciplina { get; set; }

        public Materia Materia { get; set; }

        private List<Alternativa> _alternativas;
        public List<Alternativa> Alternativas { get => _alternativas; set => _alternativas = value; }

        public void AdicionarAlternativa(Alternativa alternativaParaInserir)
        {
            if (Alternativas.Exists(x => x.Equals(alternativaParaInserir)) == false)
                _alternativas.Add(alternativaParaInserir);
        }



        public override void Atualizar(Questao registro)
        {
            Enunciado = registro.Enunciado;
            Disciplina = registro.Disciplina;
            Materia = registro.Materia;

        }

        public override string ToString()
        {
            return Enunciado;
        }
    }
}
