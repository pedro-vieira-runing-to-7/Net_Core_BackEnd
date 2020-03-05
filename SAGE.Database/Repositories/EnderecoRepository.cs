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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly SageContext _context;
        public EnderecoRepository(SageContext context)
        {
            _context = context;
        }
        public Guid Add(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            return endereco.Id;
        }

        public void Delete(Guid id)
        {
            var endereco = _context.Enderecos.Where(w => w.Id == id).FirstOrDefault();
            _context.Enderecos.Remove(endereco);
        }

        public void DeleteByIdPessoa(Guid id)
        {
            var enderecos = _context.Enderecos.Where(w => w.IdPessoa == id).ToList();

            foreach (var endereco in enderecos)
            {
                _context.Enderecos.Remove(endereco);
            }
        }

        public Endereco Get(Guid id)
        {
            return _context.Enderecos.Where(w => w.Id == id).FirstOrDefault();
        }

        public Endereco GetByIdPessoa(Guid id)
        {
            return _context.Enderecos.Where(w => w.IdPessoa == id).FirstOrDefault();
        }

        public PagedResult<Endereco> Get(int actualPage, int pageSize)
        {
            return _context.Enderecos.GetPaged(actualPage, pageSize);
        }


        public void Update(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);            
        }
    }
}
