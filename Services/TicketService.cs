using estudo_strategy.Interfaces;
using estudo_strategy.Repository;
using estudo_strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Services
{
    public class TicketService
    {
        private readonly NotificationContext _notificationContext;
        private readonly TicketRepository _ticketRepository;

        public TicketService(NotificationContext notificationContext, TicketRepository ticketRepository)
        {
            _notificationContext = notificationContext;
            _ticketRepository = ticketRepository;
        }
        /// <summary>
        /// metodo que cria um ticket sem notificação via e-mail
        /// </summary>
        /// <param name="ticketInfo"></param>
        /// <returns></returns>
        public ITicketInfo CreateTicketWithoutMailNotification(ITicketInfo ticketInfo) {

            if (ticketInfo.Invalid)
            {
                _notificationContext.AddNotifications(ticketInfo.ValidationResult);
            }
            //regras para criação de ticket sem notificação
            return ticketInfo;
        }

        /// <summary>
        /// metodo que cria um ticket com notificação via e-mail
        /// </summary>
        /// <param name="ticketInfo"></param>
        /// <returns></returns>
        public ITicketInfo CreateTicketWithMailNotification(ITicketInfo ticketInfo)
        {
            //regras para criação de ticket com notificação
            return ticketInfo;
        }
    }
}
