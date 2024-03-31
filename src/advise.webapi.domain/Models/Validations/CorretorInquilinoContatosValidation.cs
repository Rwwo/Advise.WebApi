using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class CorretorInquilinoContatosValidation : AbstractValidator<CorretorInquilinoContatos>
    {
        public CorretorInquilinoContatosValidation()
        {
            RuleFor(c => c.DescricaoContato)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.InquilinoId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.CorretorId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
