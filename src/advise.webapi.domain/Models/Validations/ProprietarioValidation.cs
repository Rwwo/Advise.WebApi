using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class ProprietarioValidation : AbstractValidator<Proprietario>
    {
        public ProprietarioValidation()
        {
            RuleFor(proprietario => proprietario.Nome)
                .NotEmpty().WithMessage("O nome do proprietário é obrigatório.");

            RuleFor(proprietario => proprietario.Telefone)
                .NotEmpty().WithMessage("O telefone do proprietário é obrigatório.");

        }
    }
}

