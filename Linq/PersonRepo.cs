using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class PersonRepo
    {
        public List<Person> People { get; }

        public PersonRepo()
        {
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(1990, 1, 10),
                Address = new Address()
                {
                    City = "Blackpool",
                    Country = "England"
                },
                FirstName = "Stuart",
                LastName = "Bradley",
                Height = 5.7m,
                Profession = "Software Engineer"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(1995, 11, 20),
                Address = new Address()
                {
                    City = "London",
                    Country = "England"
                },
                FirstName = "Wes",
                LastName = "Lowe",
                Height = 5.9m,
                Profession = "Software Engineer"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(1940, 12, 1),
                Address = new Address()
                {
                    City = "Benidorm",
                    Country = "Spain"
                },
                FirstName = "Phil",
                LastName = "Juan",
                Height = 5.10m,
                Profession = "Painter"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(1990, 1, 10),
                Address = new Address()
                {
                    City = "Texas",
                    Country = "USA"
                },
                FirstName = "Billy",
                LastName = "Loki",
                Height = 5.7m,
                Profession = "CEO"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(2001, 11, 5),
                Address = new Address()
                {
                    City = "Tamworth",
                    Country = "England"
                },
                FirstName = "Becky",
                LastName = "Hardy",
                Height = 5.4m,
                Profession = "Self Employed"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(2005, 2, 4),
                Address = new Address()
                {
                    City = "Blackpool",
                    Country = "England"
                },
                FirstName = "Simon",
                LastName = "Bradley",
                Height = 5.7m,
                Profession = "Housing"
            });
            People.Add(new Person()
            {
                DateOfBirth = new DateTime(1987, 1, 11),
                Address = new Address()
                {
                    City = "Pairs",
                    Country = "France"
                },
                FirstName = "Phillip",
                LastName = "Bread",
                Height = 6.1m,
                Profession = "Frog Catcher"
            });
        }
    }
}
