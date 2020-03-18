using FSOLID.Commom.Pagging;
using FSOLID.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Interfaces
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
