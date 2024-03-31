using FluentValidation;

namespace advise.webapi.core.Models.Validations
{
    public class InquilinoImovelLocacaoValidation : AbstractValidator<InquilinoImovelLocacao>
    {
        public InquilinoImovelLocacaoValidation()
        {
            RuleFor(locacao => locacao.DataEntrada)
                .NotEmpty().WithMessage("A data de entrada é obrigatória.");

            RuleFor(locacao => locacao.DataSaida)
                .GreaterThan(locacao => locacao.DataEntrada)
                .When(locacao => locacao.DataSaida.HasValue)
                .WithMessage("A data de saída deve ser posterior à data de entrada, se fornecida.");

            RuleFor(locacao => locacao.AtendimentoCorretorId)
                .NotEmpty().WithMessage("O ID do atendimento do corretor é obrigatório.");
            
            RuleFor(locacao => locacao.InquilinoId)
                .NotEmpty().WithMessage("O ID do inquilino é obrigatório.");
            
            RuleFor(locacao => locacao.ImovelId)
                .NotEmpty().WithMessage("O ID do imóvel é obrigatório.");

        }
    }
}

