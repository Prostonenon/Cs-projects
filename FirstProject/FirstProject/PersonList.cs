using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class PersonList
    {
        private List<Person> people;

        public PersonList()
        {
            people = new List<Person>();
        }
        public void add(Person person)
        {
            people.Add(person);
        }
        public void printAll()
        {
            for (int i = 0; i < people.Count(); i++)
                people[i].printInfo();
        }
    }
}
