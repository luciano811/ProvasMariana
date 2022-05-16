using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.ModuloQuestao
{
    public class Alternativa:EntidadeBase<Alternativa>
    {
        public string Texto { get; set; }
        public bool Certa { get; set; }
        public int Num { get; set; }


        public override void Atualizar(Alternativa registro)
        {
           
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
