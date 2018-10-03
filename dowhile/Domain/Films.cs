using System;
using System.Collections.Generic;
using System.Text;

namespace dowhile.Domain
{
    public class Films
    {
        int amountAvailable = 20;
        int ticketsRest;
        int ticketsNumber;

        public void CountTicketsRest(int ticketsNumber)
        {
            if (ticketsNumber > amountAvailable)            
            {
                Console.WriteLine("Sorry, we don't have that many tickets available");
            }
            else
            {
                amountAvailable = amountAvailable - ticketsNumber;

                Console.WriteLine("Congratulations, you just bought " + ticketsNumber + " tickets!");
            }
        }
    }
}



