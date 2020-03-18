using FSOLID.Commom.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public Endereco(Guid idPessoa, int idStatus, int idTipoEndereco, string logradouro, string numero, string bairro, string cidade, string cep, Guid idEstado)
        {
            IdPessoa = idPessoa;
            IdStatus = idStatus;
            IdTipoEndereco = idTipoEndereco;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            IdEstado = idEstado;
        }

        public Endereco(Guid id, Guid idPessoa, int idStatus, int idTipoEndereco, string logradouro, string numero, string bairro, string cidade, string cep, Guid idEstado)
        {
            Id = id;
            IdPessoa = idPessoa;
            IdStatus = idStatus;
            IdTipoEndereco = idTipoEndereco;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            IdEstado = idEstado;
        }

        public Guid IdPessoa { get; set; }
        public int IdStatus { get; set; }
        public int IdTipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public Guid IdEstado { get; set; }

        public virtual Pessoa IdPessoaNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
    }
}
