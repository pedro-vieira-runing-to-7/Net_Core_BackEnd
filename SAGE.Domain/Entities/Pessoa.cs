using System;
using System.Collections.Generic;
using SAGE.Commom.Entities;

namespace SAGE.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public Pessoa()
        {
            Endereco = new HashSet<Endereco>();
        }

        public Pessoa(int idStatus, int idTipoPessoa, string nome, string nomeSocial, string cpfCnpj, string rgIe, DateTime? dataNascimentoAbertura, string sexo, string email, string numeroTelefoneFixo, string numeroCelular)
        {
            DataCadastro = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            IdStatus = idStatus;
            IdTipoPessoa = idTipoPessoa;
            Nome = nome;
            NomeSocial = nomeSocial;
            CpfCnpj = cpfCnpj;
            RgIe = rgIe;
            DataNascimentoAbertura = dataNascimentoAbertura;
            Sexo = sexo;
            Email = email;
            NumeroTelefoneFixo = numeroTelefoneFixo;
            NumeroCelular = numeroCelular;
        }

        public Pessoa(Guid id, int idStatus, int idTipoPessoa, string nome, string nomeSocial, string cpfCnpj, string rgIe, DateTime? dataNascimentoAbertura, string sexo, string email, string numeroTelefoneFixo, string numeroCelular)
        {
            Id = id;
            DataAtualizacao = DateTime.Now;
            IdStatus = idStatus;
            IdTipoPessoa = idTipoPessoa;
            Nome = nome;
            NomeSocial = nomeSocial;
            CpfCnpj = cpfCnpj;
            RgIe = rgIe;
            DataNascimentoAbertura = dataNascimentoAbertura;
            Sexo = sexo;
            Email = email;
            NumeroTelefoneFixo = numeroTelefoneFixo;
            NumeroCelular = numeroCelular;
        }

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

        public ICollection<Endereco> Endereco { get; set; }
    }
}
