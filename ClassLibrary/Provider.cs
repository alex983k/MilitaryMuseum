using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Provider
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public Provider(int id, string name, string email, string phone)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
