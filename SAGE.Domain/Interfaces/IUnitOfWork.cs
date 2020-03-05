using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
