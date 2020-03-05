using SAGE.Commom.Pagging;
using SAGE.Database.Context;
using SAGE.Domain.Entities;
using SAGE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGE.Database.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly SageContext _context;
        public EstadoRepository(SageContext context)
        {
            _context = context;
        }
        public Guid Add(Estado estado)
        {
            _context.Estados.Add(estado);
            return estado.Id;
        }

        public void Delete(Guid id)
        {
            var estado = _context.Estados.Where(w => w.Id == id).FirstOrDefault();
            _context.Estados.Remove(estado);
        }

        public Estado Get(Guid id)
        {
            return _context.Estados.Where(w => w.Id == id).FirstOrDefault();
        }

        public PagedResult<Estado> Get(int actualPage, int pageSize)
        {
            return _context.Estados.GetPaged(actualPage, pageSize);
        }


        public void Update(Estado estado)
        {
            _context.Estados.Update(estado);            
        }
    }
}
