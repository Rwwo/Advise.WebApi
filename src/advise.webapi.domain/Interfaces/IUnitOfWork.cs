namespace advise.webapi.core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICorretorInquilinoContatosRepository CorretorInquilinoContatosRepository { get; }
        ICorretorProprietarioContatosRepository CorretorProprietarioContatosRepository { get; }
        ICorretorRepository CorretorRepository { get; }
        IImovelRepository ImovelRepository { get; }
        IInquilinoImovelLocacaoRepository InquilinoImovelLocacaoRepository { get; }
        IInquilinoRepository InquilinoRepository { get; }
        IProprietarioRepository ProprietarioRepository { get; }
        Task Commit();
    }

}
