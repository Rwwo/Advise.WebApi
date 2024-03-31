using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using advise.webapi.api.InputModels;
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

            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();

            CreateMap<InquilinoImovelLocacao, InquilinoImovelLocacaoViewModel>().ReverseMap();

            CreateMap<InquilinoImovelLocacao, InquilinoImovelLocacaoDetalhadaViewModel>()
                .ForMember(dest => dest.imo)

            CreateMap<CorretorInquilinoContatos, CorretorInquilinoContatosViewModel>().ReverseMap();

            CreateMap<CorretorProprietarioContatos, CorretorProprietarioContatosViewModel>().ReverseMap();

        }
    }
}
