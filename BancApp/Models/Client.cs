
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancApp
{
    class Client
    {
        public Client(Guid id, string name, string surname, int age, int salary, BancCard bancAccount)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            this.bancAccount = bancAccount;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public BancCard bancAccount { get; set; }


    }
}
