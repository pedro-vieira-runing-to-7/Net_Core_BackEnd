using SAGE.Commom.Pagging;
using SAGE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Guid Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Guid id);
        Pessoa Get(Guid id);
        PagedResult<Pessoa> Get(int actualPage, int pageSize);
    }
}
