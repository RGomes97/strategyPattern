using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estudo_strategy.Interfaces;
using estudo_strategy.Models;
using estudo_strategy.Services;
using Microsoft.AspNetCore.Mvc;

namespace estudo_strategy.Controllers
{
    
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketService _ticketService;

        public TicketController(TicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        [HttpPost]
        [Route("api/ticket/withnotification")]
        public ITicketInfo Post(TicketWithMailNotification ticketInfo)
        {
            return this.CreateTicket(ticketInfo);
        }

        [HttpPost]
        [Route("api/ticket/withoutnotification")]
        public ITicketInfo Post([FromBody] TicketWithoutEmailNotification ticketInfo)
        {
            return this.CreateTicket(ticketInfo);
        }

        private ITicketInfo CreateTicket([FromBody] ITicketInfo ticketInfo)
        {
            return ticketInfo.CreateTicket(ticketInfo, _ticketService);
        }
    }
}
