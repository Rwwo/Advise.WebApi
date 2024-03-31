using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class CorretorValidation : AbstractValidator<Corretor>
    {
        public CorretorValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(8, 12).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}

