using System;
using System.Collections.Generic;

namespace FSOLID.Domain.DTO
{
    public class EstadoDTO
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public ICollection<EnderecoDTO> Endereco { get; set; }
    }
}
