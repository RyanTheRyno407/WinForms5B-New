using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms5Bnew
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person(int id, string name, string phone)
        {
             Id = id;
             Name = name;
             Phone = phone;
        }
        public Person()
        {
            Id = 0;
            Name = string.Empty;
            Phone = string.Empty;
        }
    }
}
