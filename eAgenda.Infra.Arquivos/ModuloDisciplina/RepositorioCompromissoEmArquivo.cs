using eAgenda.Dominio.ModuloDisciplina;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioEmArquivoBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Disciplinas.Count > 0)
                contador = dataContext.Disciplinas.Max(x => x.Numero);
        }

        public override List<Disciplina> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }

        public override AbstractValidator<Disciplina> ObterValidador()
        {
            return new ValidadorDisciplina();
        }       

        public List<Disciplina> SelecionarDisciplinasFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            return ObterRegistros()
                .ToList();
        }

        public List<Disciplina> SelecionarDisciplinasPassados(DateTime hoje)
        {
            return ObterRegistros()
                .ToList();
        }
    }
}
