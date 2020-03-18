using FSOLID.Database.Context;
using FSOLID.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FSolidContext _context;

        public UnitOfWork(FSolidContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
