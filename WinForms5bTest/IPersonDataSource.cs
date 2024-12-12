using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms5Bnew
{
    public interface IPersonDataSource
    {
        public IEnumerable<Person> GetPeople();
        public void SaveChanges();
    }
}
