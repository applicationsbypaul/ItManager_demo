using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace itmanager.Models
{
    public class TicketViewModel
    {
        // setting up Ticket view to have Ticket and ActiveStore info (comes from TicketSession)
        public Ticket Ticket { get; set; }
        public string ActiveStore { get; set; } = "all";
    }
}
