using SAGE.Database.Context;
using SAGE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SageContext _context;

        public UnitOfWork(SageContext context)
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
