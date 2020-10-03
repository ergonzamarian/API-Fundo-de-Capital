using System;
using System.Collections.Generic;
using System.Linq;
using Uniciv.Api.Models;

namespace Uniciv.Api.Repositories
{
    public class FundoCapitalRepository : IFundoCapitalRepository
    {
        private readonly List<FundoCapital> _storage;

        public FundoCapitalRepository()
        {
            _storage = new List<FundoCapital>();
        }

        public void Adicionar(FundoCapital fundo)
        {
            _storage.Add(fundo);
        }

        public void Alterar(FundoCapital fundo)
        {
            //estou pegando um index e salvando na variavel "index", começarei do index 0 e pegarei um elemento, por isso temos 0, 1,
            
            var index = _storage.FindIndex(0, 1, x => x.Id == fundo.Id);
            _storage[index] = fundo;
        }

        public IEnumerable<FundoCapital> ListarFundos()
        {
            return _storage;
        }

        public FundoCapital ObterPorId(Guid id)
        {
            //parte muito importante retornar o elemento da lista quando o Id passado como parâmetro for igual o Id da lista
            return _storage.FirstOrDefault(x => x.Id == id);
        }

        public void RemoverFundo(FundoCapital fundo)
        {
            _storage.Remove(fundo);
        }
    }
}