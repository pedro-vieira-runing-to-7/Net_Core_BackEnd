using SAGE.Commom.Pagging;
using SAGE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Interfaces
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
