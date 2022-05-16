using eAgenda.Dominio.Compartilhado;
using System;

namespace eAgenda.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Assunto { get; set; }             
        
        public override void Atualizar(Disciplina registro)
        {
            Assunto = registro.Assunto;
        }
        public override string ToString()
        {
            return $"{Assunto}";
        }
    }
}
