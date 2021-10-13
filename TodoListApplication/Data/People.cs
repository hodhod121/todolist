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
       
        private static Person[] array = new Person[0];

        public People(Person[] array)
        {
        }

        public int Size()
        {
            return array.Length;
        }
        public Person[] FindAll()
        {
            return array;
        }
        public Person FindById(int personId)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].personId == personId)
                {
                    return array[i];                  
                }
            }
            return null;
        }
        public Person Create(int id,string first_name,string last_name)
        {
            PersonSequencer ps = new PersonSequencer();
            Person person=new Person(ps.nextPersonId(), first_name, last_name);
            Person[] newArray=new Person[array.Length+1];
            for(int i= 0; i<array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = person;
            array = newArray;
            return person;
        }
        public void Clear()
        {
            Array.Clear(array, 0, array.Length);           
        }
        public Person[] RemovePersonFromPersonArray(Person person)
        {
            Person[] newPerson = new Person[array.Length - 1];
            for (int i = 0; i < Size(); i++)
            {
                if (array[i] != person)
                {
                    newPerson[i] = array[i];
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
