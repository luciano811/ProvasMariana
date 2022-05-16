using eAgenda.Dominio.ModuloProva;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos.ModuloProva
{
    public class RepositorioProvaEmArquivo : RepositorioEmArquivoBase<Prova>, IRepositorioProva
    {
        public RepositorioProvaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Provas.Count > 0)
                contador = dataContext.Provas.Max(x => x.Numero);
        }

        public override ValidationResult Inserir(Prova novoRegistro)
        {
            var resultadoValidacao = Validar(novoRegistro);

            if (resultadoValidacao.IsValid)
            {
                novoRegistro.Numero = ++contador;

                var registros = ObterRegistros();

                registros.Add(novoRegistro);
            }

            return resultadoValidacao;
        }

        public override ValidationResult Editar(Prova registro)
        {
            var resultadoValidacao = Validar(registro);

            if (resultadoValidacao.IsValid)
            {
                var registros = ObterRegistros();

                foreach (var item in registros)
                {
                    if (item.Numero == registro.Numero)
                    {
                        item.Atualizar(registro);
                        break;
                    }
                }
            }

            return resultadoValidacao;
        }

        private ValidationResult Validar(Prova registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            var nomeEncontrado = ObterRegistros()
               .Select(x => x.Conteudo)
               .Contains(registro.Conteudo);

            if (nomeEncontrado && registro.Numero == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Nome já está cadastrado"));

            return resultadoValidacao;
        }

        public override List<Prova> ObterRegistros()
        {
            return dataContext.Provas;
        }

        

       

        //public List<Prova> SelecionarTodos(StatusProvaEnum status)
        //{
        //    switch (status)
        //    {
        //        case StatusProvaEnum.Todos: return SelecionarTodos();

        //        case StatusProvaEnum.Pendentes: return SelecionarProvasPendentes();

        //        default: return SelecionarTodos();
        //    }
        //}

        public override List<Prova> SelecionarTodos()
        {
            return base.SelecionarTodos()
                .ToList();
        }

        

        private List<Prova> SelecionarProvasPendentes()
        {
            return dataContext.Provas
                .ToList();
        }

        public override AbstractValidator<Prova> ObterValidador()
        {
            return new ValidadorProva();
        }
    }
}
