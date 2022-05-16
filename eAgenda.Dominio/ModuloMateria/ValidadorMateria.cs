using FluentValidation;

namespace eAgenda.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty();
                                             
            RuleFor(x => x.Disciplina.Assunto)
                .NotNull()
                .NotEmpty();
        }
    }
}
