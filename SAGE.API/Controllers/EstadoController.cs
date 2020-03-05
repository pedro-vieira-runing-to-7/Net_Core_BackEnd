using SAGE.Commom.Notification;
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
    [Route("api/v1/Estados")]
    [ApiController]
    public class EstadoController : APIController
    {
        private readonly IEstadoRepository _EstadoRepository;
        private readonly NewEstadoCommandHandler _handler;
        private readonly UpdateEstadoCommandHandler _updatehandler;
        public EstadoController(
            IEstadoRepository EstadoRepository,
            IUnitOfWork unitOfWork,
            NewEstadoCommandHandler handler,
            UpdateEstadoCommandHandler updateHandler,
            DomainNotificationHandler domainNotificationHandler) : base(domainNotificationHandler, unitOfWork)
        {
            _EstadoRepository = EstadoRepository;
            _handler = handler;
            _updatehandler = updateHandler;
        }

        /// <summary>
        /// Retorna uma lista de Estados
        /// </summary>
        /// <param name="actualPage">pagina atual</param>
        /// <param name="pageSize">itens por página</param>
        /// <returns>Lista paginada de Estados</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _EstadoRepository.Delete(id);
            return Response();
        }

        [HttpPut("{id}")]
        public IActionResult Put(EstadoDTO estado)
        {
            var newEstadoCommand = new NewEstadoCommand(estado);
            _updatehandler.Handle(newEstadoCommand);
            return Response(newEstadoCommand);
        }

        [HttpGet()]
        public ActionResult<PagedResult<Estado>> Get(int actualPage = 1, int pageSize = 20)
        {
            return Ok(_EstadoRepository.Get(actualPage, pageSize));
        }

        [HttpGet("{id}")]
        public ActionResult<PagedResult<Estado>> Get(Guid id)
        {
            return Ok(_EstadoRepository.Get(id));
        }

        [HttpPost()]        
        public IActionResult Post(EstadoDTO estado)
        {
            var newEstadoCommand = new NewEstadoCommand(estado);
            _handler.Handle(newEstadoCommand);
            return Response(newEstadoCommand);
        }
    }
}
