using estudo_strategy.Interfaces;
using estudo_strategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Models
{
    public class TicketWithoutEmailNotification : ITicketInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Number { get; set; }
        public Guid TenantId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LimitDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ReopenDate { get; set; }
        public Guid ScopeId { get; set; }
        public string Type { get; set; }
        public string StateName { get; set; }
        public string StateLabel { get; set; }
        public Guid StateId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid LastChangeUserId { get; set; }
        public string LastChangeUserName { get; set; }
        public Guid GroupId { get; set; }
        public bool GroupActive { get; set; }
        public string GroupName { get; set; }

        /// <summary>
        /// parametro para mandar o e-mail ao cliente
        /// </summary>
        public string CostumerMail { get; set; }

        public ITicketInfo CreateTicket(ITicketInfo ticketInfo, TicketService ticketService)
        {
            return ticketService.CreateTicketWithoutMailNotification(ticketInfo);
        }
    }
}
