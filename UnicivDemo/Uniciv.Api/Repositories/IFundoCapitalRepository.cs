using System;
using System.Collections.Generic;
using Uniciv.Api.Models;

namespace Uniciv.Api.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundo);
        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundos();
        FundoCapital ObterPorId(Guid id);
        void RemoverFundo(FundoCapital fundo);

        
        
    }
}