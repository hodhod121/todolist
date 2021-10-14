using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Model
{
      public class Person
    {
        public  Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
        }

        public  int personId  { get;}
        private string firstName;
        private string lastName;
      
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!(value == null || value==string.Empty))
                {
                    firstName = value;
                }             
            }
        }       
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != null && value != string.Empty)
                {
                    lastName = value;
                }
            }
        }           
    }
}
