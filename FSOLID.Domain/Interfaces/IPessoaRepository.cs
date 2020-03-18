using FSOLID.Commom.Pagging;
using FSOLID.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Interfaces
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
