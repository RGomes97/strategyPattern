using estudo_strategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Interfaces
{
    public interface ITicketInfo
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        long Number { get; set; }
        Guid TenantId { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? LimitDate { get; set; }
        DateTime? EndDate { get; set; }
        DateTime? ReopenDate { get; set; }
        Guid ScopeId { get; set; }
        string Type { get; set; }
        string StateName { get; set; }
        string StateLabel { get; set; }
        Guid StateId { get; set; }
        Guid UserId { get; set; }
        string UserName { get; set; }
        Guid LastChangeUserId { get; set; }
        string LastChangeUserName { get; set; }
        Guid GroupId { get; set; }
        bool GroupActive { get; set; }
        string GroupName { get; set; }

        ITicketInfo CreateTicket(ITicketInfo ticketInfo, TicketService ticketService);
    }
}
