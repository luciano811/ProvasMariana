using eAgenda.Dominio.Compartilhado;
using eAgenda.Dominio.ModuloDisciplina;
using System;

namespace eAgenda.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        
        public string Descricao { get; set; }

        public Disciplina Disciplina { get; set; }

        public SerieMateriaEnum SerieMateria { get; set; }


        public override void Atualizar(Materia registro)
        {
            Descricao = registro.Descricao;

            Disciplina = registro.Disciplina;

            SerieMateria = registro.SerieMateria;


        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
