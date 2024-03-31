using System.ComponentModel.DataAnnotations;

namespace advise.webapi.api.InputModels
{
    public class InquilinoImovelLocacaoDetalhadaViewModel
    {

        public DateTime DataEntrada { get; set; }

        public DateTime? DataSaida { get; set; }

        public ImovelViewModel Imovel { get; set; }
        public ProprietarioViewModel Proprietario { get; set; }

        public CorretorViewModel Corretor { get; set; }
    }

}
