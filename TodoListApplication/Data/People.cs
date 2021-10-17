using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Model;

namespace TodoListApplication.Data
{
      public class People
    {
       
        public static Person[] personArray = new Person[0];

        public People(Person[] array)
        {
        }

        public int Size()
        {
            return personArray.Length;
        }
        public Person[] FindAll()
        {
            return personArray;
        }
        public Person FindById(int personId)
        {
            for (int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i].personId == personId)
                {
                    return personArray[i];                  
                }
            }
            return null;
        }
        public Person Create(int id,string first_name,string last_name)
        {           
            Person person=new Person(PersonSequencer.nextPersonId(), first_name, last_name);
            Person[] newArray=new Person[personArray.Length+1];
            for(int i= 0; i< personArray.Length; i++)
            {
                newArray[i] = personArray[i];
            }
            newArray[personArray.Length] = person;
            personArray = newArray;
            return person;
        }
        public void Clear()
        {
            personArray = new Person[0];           
        }
        public Person[] RemovePersonFromPersonArray(Person person)
        {
            Person[] newPerson = new Person[personArray.Length - 1];
            for (int i = 0; i < Size(); i++)
            {
                if (personArray[i] != person)
                {
                    newPerson[i] = personArray[i];
                }
            }
            if (newPerson.Length > 0)
            {
                return newPerson;
            }
            else
            {
                Console.WriteLine("Not found");
                return null;
            }
        }
    }
}
