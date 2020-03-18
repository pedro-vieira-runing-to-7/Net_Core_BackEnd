using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
