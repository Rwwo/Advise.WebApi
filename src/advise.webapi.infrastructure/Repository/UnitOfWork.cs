using advise.webapi.core.Interfaces;
using advise.webapi.infrastructure.Context;

using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApiContext _dbContext;
        public UnitOfWork(ApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        private ICorretorInquilinoContatosRepository _CorretorInquilinoContatosRepository = null;
        public ICorretorInquilinoContatosRepository CorretorInquilinoContatosRepository
        {
            get => _CorretorInquilinoContatosRepository ?? (_CorretorInquilinoContatosRepository = new CorretorInquilinoContatosRepository(_dbContext));
        }

        private ICorretorProprietarioContatosRepository _CorretorProprietarioContatosRepository = null;
        public ICorretorProprietarioContatosRepository CorretorProprietarioContatosRepository
        {
            get => _CorretorProprietarioContatosRepository ?? (_CorretorProprietarioContatosRepository = new CorretorProprietarioContatosRepository(_dbContext));
        }

        private ICorretorRepository _CorretorRepository = null;
        public ICorretorRepository CorretorRepository
        {
            get => _CorretorRepository ?? (_CorretorRepository = new CorretorRepository(_dbContext));
        }

        private IImovelRepository _ImovelRepository = null;
        public IImovelRepository ImovelRepository
        {
            get => _ImovelRepository ?? (_ImovelRepository = new ImovelRepository(_dbContext));
        }

        private IInquilinoImovelLocacaoRepository _InquilinoImovelLocacaoRepository = null;
        public IInquilinoImovelLocacaoRepository InquilinoImovelLocacaoRepository
        {
            get => _InquilinoImovelLocacaoRepository ?? (_InquilinoImovelLocacaoRepository = new InquilinoImovelLocacaoRepository(_dbContext));
        }

        private IInquilinoRepository _InquilinoRepository = null;
        public IInquilinoRepository InquilinoRepository
        {
            get => _InquilinoRepository ?? (_InquilinoRepository = new InquilinoRepository(_dbContext));
        }

        private IProprietarioRepository _ProprietarioRepository = null;
        public IProprietarioRepository ProprietarioRepository
        {
            get => _ProprietarioRepository ?? (_ProprietarioRepository = new ProprietarioRepository(_dbContext));
        }


        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
