using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Person
    {
        private string first_name;
        private string last_name;
        private string address;
        private enum Gender { Male, Female, Unspecified};
        private DateTime birthDate;

        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }
    }
}
