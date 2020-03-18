using FSOLID.Commom.Notification;
using FSOLID.Commom.Pagging;
using FSOLID.Commom.Publisher;
using FSOLID.Domain.Commands;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Entities;
using FSOLID.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FSOLID.Service.Controllers
{
    [Route("api/v1/Pessoas")]
    [ApiController]
    public class PessoaController : APIController
    {
        private readonly IPessoaRepository _PessoaRepository;
        private readonly NewPessoaCommandHandler _handler;
        private readonly UpdatePessoaCommandHandler _updatehandler;
        public PessoaController(
            IPessoaRepository PessoaRepository,
            IUnitOfWork unitOfWork,
            NewPessoaCommandHandler handler,
            UpdatePessoaCommandHandler updateHandler,
            DomainNotificationHandler domainNotificationHandler) : base(domainNotificationHandler, unitOfWork)
        {
            _PessoaRepository = PessoaRepository;
            _handler = handler;
            _updatehandler = updateHandler;
        }

        /// <summary>
        /// Retorna uma lista de Pessoas
        /// </summary>
        /// <param name="actualPage">pagina atual</param>
        /// <param name="pageSize">itens por página</param>
        /// <returns>Lista paginada de Pessoas</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _PessoaRepository.Delete(id);
            return Response();
        }

        [HttpPut("{id}")]
        public IActionResult Put(PessoaDTO pessoa)
        {
            var updatePessoaCommand = new UpdatePessoaCommand(pessoa);
            _updatehandler.Handle(updatePessoaCommand);
            return Response(updatePessoaCommand);
        }

        [HttpGet()]
        public ActionResult<PagedResult<Pessoa>> Get(int actualPage = 1, int pageSize = 20)
        {
            return Ok(_PessoaRepository.Get(actualPage, pageSize));
        }

        [HttpGet("{id}")]
        public ActionResult<PagedResult<Pessoa>> Get(Guid id)
        {
            return Ok(_PessoaRepository.Get(id));
        }

        [HttpPost()]        
        public IActionResult Post(PessoaDTO pessoa)
        {
            var newPessoaCommand = new NewPessoaCommand(pessoa);
            _handler.Handle(newPessoaCommand);
            return Response(newPessoaCommand);
        }
    }
}
