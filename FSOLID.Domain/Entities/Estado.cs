using FSOLID.Commom.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Entities
{
    public class Estado : BaseEntity
    {
        public Estado()
        {
            Endereco = new HashSet<Endereco>();
        }

        public Estado(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public Estado(Guid id, string sigla, string nome)
        {  
            Id = id;
            Sigla = sigla;
            Nome = nome;
        }

        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
