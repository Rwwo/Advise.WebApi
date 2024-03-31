using advise.webapi.core.InputModels;
using advise.webapi.core.Models;

using AutoMapper;

namespace advise.webapi.application.Profiles
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Inquilino, InquilinoViewModel>().ReverseMap();

            CreateMap<Corretor, CorretorViewModel>().ReverseMap();

            CreateMap<Proprietario, ProprietarioViewModel>().ReverseMap();

            CreateMap<Imovel, ImovelViewModel>().ReverseMap();

            CreateMap<Imovel, ImovelDetalhadoViewModel>().ReverseMap();

            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();

            CreateMap<InquilinoImovelLocacao, InquilinoImovelLocacaoViewModel>().ReverseMap();

            CreateMap<InquilinoImovelLocacao, InquilinoImovelLocacaoDetalhadaViewModel>()
                .ForMember(dest => dest.Imovel, opt => opt.MapFrom(src => src.Imovel))
                .ForMember(dest => dest.Inquilino, opt => opt.MapFrom(src => src.Inquilino))
                .ForMember(dest => dest.Corretor, opt => opt.MapFrom(src => src.AtendimentoCorretor.Corretor))
                .ForMember(dest => dest.Proprietario, opt => opt.MapFrom(src => src.Imovel.Proprietario))
                ;

            CreateMap<CorretorInquilinoContatos, CorretorInquilinoContatosViewModel>().ReverseMap();

            CreateMap<CorretorProprietarioContatos, CorretorProprietarioContatosViewModel>().ReverseMap();

        }
    }
}
