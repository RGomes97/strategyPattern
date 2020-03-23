using estudo_strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Services
{
    public class TicketService
    {
        /// <summary>
        /// metodo que cria um ticket sem notificação via e-mail
        /// </summary>
        /// <param name="ticketInfo"></param>
        /// <returns></returns>
        public ITicketInfo CreateTicketWithoutMailNotification(ITicketInfo ticketInfo) {
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
