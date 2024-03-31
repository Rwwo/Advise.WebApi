using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class ImovelValidation : AbstractValidator<Imovel>
    {
        public ImovelValidation()
        {
            RuleFor(imovel => imovel.QtdeQuartos)
                .GreaterThan(0).WithMessage("A quantidade de quartos deve ser maior que zero.");

            RuleFor(imovel => imovel.QtdeBanheiros)
                .GreaterThan(0).WithMessage("A quantidade de banheiros deve ser maior que zero.");

            RuleFor(imovel => imovel.QtdeVagasGaragem)
                .GreaterThanOrEqualTo(0).WithMessage("A quantidade de vagas na garagem não pode ser negativa.");

            RuleFor(imovel => imovel.TipoImovel)
                .IsInEnum().WithMessage("O tipo de imóvel fornecido não é válido.");

            RuleFor(imovel => imovel.PosicaoSolar)
                .IsInEnum().WithMessage("A posição solar fornecida não é válida.");

            RuleFor(imovel => imovel.Valor)
                .GreaterThan(0).WithMessage("O valor do imóvel deve ser maior que zero.");

            RuleFor(imovel => imovel.Observacoes)
                .MaximumLength(500).WithMessage("As observações devem ter no máximo 500 caracteres.");

            RuleFor(imovel => imovel.Status)
                .NotNull().WithMessage("O status do imóvel é obrigatório.");

            RuleFor(imovel => imovel.ProprietarioId)
                .NotNull().WithMessage("O proprietário do imóvel é obrigatório.");
        }
    }
}

