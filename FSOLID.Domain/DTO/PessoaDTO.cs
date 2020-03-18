using System;
using System.Collections.Generic;

namespace FSOLID.Domain.DTO
{
    public class PessoaDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdStatus { get; set; }
        public int IdTipoPessoa { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string CpfCnpj { get; set; }
        public string RgIe { get; set; }
        public DateTime? DataNascimentoAbertura { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string NumeroTelefoneFixo { get; set; }
        public string NumeroCelular { get; set; }
        public ICollection<EnderecoDTO> Endereco { get; set; }
    }
}
