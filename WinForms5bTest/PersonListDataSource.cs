using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms5Bnew;

namespace WinForms5bnew
{
    public class PersonListDataSource : IPersonDataSource
    {
        private List<Person> PeopleList = new List<Person>()
        {
          new Person(1,"Robert", "333555"),new Person(2,"Josh", "77456"), new Person(3, "Rebecca", "778882")
        };

        public IEnumerable<Person> GetPeople()
        {
            return PeopleList.ToList();
        }

        public void SaveChanges()
        {

        }
        
    }
}
