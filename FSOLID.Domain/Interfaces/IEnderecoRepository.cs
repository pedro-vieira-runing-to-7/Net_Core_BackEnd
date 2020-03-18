using FSOLID.Commom.Pagging;
using FSOLID.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        Guid Add(Endereco endereco);
        void Update(Endereco endereco);
        void Delete(Guid id);
        Endereco Get(Guid id);
        PagedResult<Endereco> Get(int actualPage, int pageSize);
    }
}
