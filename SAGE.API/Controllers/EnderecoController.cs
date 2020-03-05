﻿using SAGE.Commom.Notification;
using SAGE.Commom.Pagging;
using SAGE.Commom.Publisher;
using SAGE.Domain.Commands;
using SAGE.Domain.DTO;
using SAGE.Domain.Entities;
using SAGE.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SAGE.Service.Controllers
{
    [Route("api/v1/Enderecos")]
    [ApiController]
    public class EnderecoController : APIController
    {
        private readonly IEnderecoRepository _EnderecoRepository;
        private readonly NewEnderecoCommandHandler _handler;
        private readonly UpdateEnderecoCommandHandler _updatehandler;
        public EnderecoController(
            IEnderecoRepository EnderecoRepository,
            IUnitOfWork unitOfWork,
            NewEnderecoCommandHandler handler,
            UpdateEnderecoCommandHandler updateHandler,
            DomainNotificationHandler domainNotificationHandler) : base(domainNotificationHandler, unitOfWork)
        {
            _EnderecoRepository = EnderecoRepository;
            _handler = handler;
            _updatehandler = updateHandler;
        }

        /// <summary>
        /// Retorna uma lista de Enderecos
        /// </summary>
        /// <param name="actualPage">pagina atual</param>
        /// <param name="pageSize">itens por página</param>
        /// <returns>Lista paginada de Enderecos</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _EnderecoRepository.Delete(id);
            return Response();
        }

        [HttpPut("{id}")]
        public IActionResult Put(EnderecoDTO endereco)
        {
            var newEnderecoCommand = new NewEnderecoCommand(endereco);
            _updatehandler.Handle(newEnderecoCommand);
            return Response(newEnderecoCommand);
        }

        [HttpGet()]
        public ActionResult<PagedResult<Endereco>> Get(int actualPage = 1, int pageSize = 20)
        {
            return Ok(_EnderecoRepository.Get(actualPage, pageSize));
        }

        [HttpGet("{id}")]
        public ActionResult<PagedResult<Endereco>> Get(Guid id)
        {
            return Ok(_EnderecoRepository.Get(id));
        }

        [HttpPost()]        
        public IActionResult Post(EnderecoDTO endereco)
        {
            var newEnderecoCommand = new NewEnderecoCommand(endereco);
            _handler.Handle(newEnderecoCommand);
            return Response(newEnderecoCommand);
        }
    }
}
