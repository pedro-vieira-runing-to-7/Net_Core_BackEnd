using SAGE.Commom.Pagging;
using SAGE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        Guid Add(Estado estado);
        void Update(Estado estado);
        void Delete(Guid id);
        Estado Get(Guid id);
        PagedResult<Estado> Get(int actualPage, int pageSize);
    }
}
