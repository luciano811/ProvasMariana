using eAgenda.Dominio.ModuloQuestao;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questões.Count > 0)
                contador = dataContext.Questões.Max(x => x.Numero);
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questões;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }
    }
}
