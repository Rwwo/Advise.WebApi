using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class CorretorProprietarioContatosValidation : AbstractValidator<CorretorProprietarioContatos>
    {
        public CorretorProprietarioContatosValidation()
        {
            RuleFor(c => c.DescricaoContato)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.ProprietarioId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.CorretorId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
