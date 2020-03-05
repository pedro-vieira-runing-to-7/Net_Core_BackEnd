﻿using SAGE.Commom.Notification;
using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Entities;
using SAGE.Domain.Events;
using SAGE.Domain.Interfaces;
using SAGE.Domain.Validations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace SAGE.Domain.Commands
{
    public class UpdatePessoaCommandHandler
    {
        private readonly IPessoaRepository _PessoaRepository;        
        private readonly DomainNotificationHandler _domainNotificationHandler;
        public UpdatePessoaCommandHandler(IPessoaRepository PessoaRepository,  DomainNotificationHandler domainNotificationHandler)
        {
            _PessoaRepository = PessoaRepository;            
            _domainNotificationHandler = domainNotificationHandler;
        }

        public Task<Unit> Handle(NewPessoaCommand command)
        {
            if (!command.IsValid())
            {
                command.ValidationResult.Errors.ToList().ForEach(error => _domainNotificationHandler.Handle(new DomainNotification(command.GetType().ToString(), error.ErrorMessage)));
                return Unit.Task;
            }

            Pessoa pessoa = new Pessoa(command.Pessoa.Id,
                                       command.Pessoa.IdStatus,
                                       command.Pessoa.IdTipoPessoa,
                                       command.Pessoa.Nome,
                                       command.Pessoa.NomeSocial,
                                       command.Pessoa.CpfCnpj,
                                       command.Pessoa.RgIe,
                                       command.Pessoa.DataNascimentoAbertura,
                                       command.Pessoa.Sexo,
                                       command.Pessoa.Email,
                                       command.Pessoa.NumeroTelefoneFixo,
                                       command.Pessoa.NumeroCelular);

            var configPessoa = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EnderecoDTO, Endereco>();
            });

            IMapper mapper = configPessoa.CreateMapper();
            pessoa.Endereco = mapper.Map<ICollection<EnderecoDTO>, ICollection<Endereco>>(command.Pessoa.Endereco);

            _PessoaRepository.Update(pessoa);

            return Unit.Task;
        }
    }
}
