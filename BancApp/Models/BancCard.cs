using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancApp
{
    class BancCard
    {
        public BancCard(string bankname, string fullname, string pan, string pin, string cvc, DateTime expireDate, int balance)
        {
            Bankname = bankname;
            Fullname = fullname;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpireDate = expireDate;
            Balance = balance;
        }

        public string Bankname { get; set; }
        public string Fullname { get; set; }
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Balance { get; set; }

    }
}
