namespace advise.webapi.core.InputModels
{
    public class InquilinoImovelLocacaoDetalhadaViewModel
    {

        public DateTime DataEntrada { get; set; }

        public DateTime? DataSaida { get; set; }

        public ImovelDetalhadoViewModel Imovel { get; set; }
        public InquilinoViewModel Inquilino { get; set; }
        public ProprietarioViewModel Proprietario { get; set; }

        public CorretorViewModel Corretor { get; set; }
    }

}
