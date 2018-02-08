using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string sex;

        public Person()
        {
            id = 1;
            firstname = "Arek";
            lastname = "Sadowski";
            age = 16;
        }
        public Person(int id, string firstname, string lastname, string address, int age, string sex)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.age = age;
            this.sex = sex;
        }
        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;
        }
    }
}
