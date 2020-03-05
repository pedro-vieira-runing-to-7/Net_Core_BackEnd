using SAGE.Commom.Pagging;
using SAGE.Database.Context;
using SAGE.Domain.Entities;
using SAGE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGE.Database.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly SageContext _context;
        public PessoaRepository(SageContext context)
        {
            _context = context;
        }
        public Guid Add(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            return pessoa.Id;
        }

        public void Delete(Guid id)
        {
            var pessoa = _context.Pessoas.Where(w => w.Id == id).FirstOrDefault();
            _context.Pessoas.Remove(pessoa);
        }

        public Pessoa Get(Guid id)
        {
            return _context.Pessoas.Where(w => w.Id == id).FirstOrDefault();
        }

        public PagedResult<Pessoa> Get(int actualPage, int pageSize)
        {
            return _context.Pessoas.GetPaged(actualPage, pageSize);
        }


        public void Update(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);            
        }
    }
}
