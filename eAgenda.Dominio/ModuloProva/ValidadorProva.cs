using FluentValidation;
using System;

namespace eAgenda.Dominio.ModuloProva
{
    public class ValidadorProva : AbstractValidator<Prova>
    {
        public ValidadorProva()
        {
            RuleFor(x => x.Conteudo)
                .NotNull().NotEmpty();

            RuleFor(x => x.DataProva)
                .NotEqual(DateTime.MinValue)
                .WithMessage("O campo Data de Prova é obrigatório");
        }
    }
}