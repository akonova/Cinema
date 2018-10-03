using System;
using System.Collections.Generic;
using System.Text;

namespace dowhile.Domain
{
    public class Films
    {
        int amountOfTickets = 20; //{ get; set; }
        int ticketsRest; //{ get; set; }
        int ticketsnumber;

        public int CountTicketsRest(int ticketsnumber)
        {
            if ()


            do
            {
               ticketsRest = amountOfTickets - ticketsnumber;
               return ticketsRest;
            }
            while (ticketsRest > 0);

            Console.WriteLine(" All tickets are sold.");
        }
    }
}



