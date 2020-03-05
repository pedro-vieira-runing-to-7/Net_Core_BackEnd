using System;

namespace SAGE.Domain.DTO
{
    public class EnderecoDTO
    {
        public Guid Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int IdStatus { get; set; }
        public int IdTipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public Guid IdEstado { get; set; }
    }
}
