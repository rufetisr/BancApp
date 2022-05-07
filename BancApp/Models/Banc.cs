using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancApp
{
    class Banc
    {
        public Banc(Client[] clients)
        {
            Clients = clients;
        }

        public Client[] Clients { get; set; }
        public void ShowCardBalance(BancCard bancCard) => Console.WriteLine($"Balance: {bancCard.Balance}");

    }
}
