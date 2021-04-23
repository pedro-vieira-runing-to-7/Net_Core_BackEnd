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
            var updateEstadoCommand = new UpdateEstadoCommand(estado);
            _updatehandler.Handle(updateEstadoCommand);
            return Response(updateEstadoCommand);
        }

        [HttpGet()]
        public ActionResult<PagedResult<EstadoDTO>> Get(int actualPage = 1, int pageSize = 20)
        {
            return Ok(_EstadoRepository.Get(actualPage, pageSize));
        }

        [HttpGet("{id}")]
        public ActionResult<PagedResult<EstadoDTO>> Get(Guid id)
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
