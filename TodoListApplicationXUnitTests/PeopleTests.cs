using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Model;
using Xunit;
using TodoListApplication.Data;

namespace TodoListApplicationXUnit
{
    public class PeopleTests
    {
        
        [Fact]
        public void People_ReturnsTrue()
        {
            People people;
            Person person1;
            Person[] array1;
            person1 = new Person(1, "Ali", "Ezadkhaha");
            array1 = new Person[4];
            array1[0] = new Person(1, "Ali", "Ezadkhaha");
            array1[1] = new Person(2, "Benji", "Ezad");
            array1[2] = new Person(3, "Billy", "Bardhyll");
            array1[3] = new Person(4, "Ahmed", "gholi");
            people = new People(array1);
            Assert.False(people.Size() == 1);
            Assert.True(array1.Length == 4);
        }
        [Fact]
        public void People_FindAll_ReturnsTrue()
        {
            People people;
            Person person1;
            Person[] array1;
            person1 = new Person(1, "Ali", "Ezadkhaha");
            array1 = new Person[4];
            array1[0] = new Person(1, "Ali", "Ezadkhaha");
            array1[1] = new Person(2, "Benji", "Ezad");
            array1[2] = new Person(3, "Billy", "Bardhyll");
            array1[3] = new Person(4, "Ahmed", "gholi");
            people = new People(array1);
            Assert.Equal(array1[0].personId, person1.personId);
            Assert.True(array1.Length == 4);
        }

        [Fact]

        public void FindById_ReturnsTrue()
        {
            People people;
            Person[] array1;
            array1 = new Person[4];
            array1[0] = new Person(PersonSequencer.nextPersonId(), "Ali", "Ezadkhaha");
            array1[1] = new Person(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            people = new People(array1);
            array1[2] = people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            array1[3] = people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            people = new People(array1);
            Person expected = new Person(2, "gholi", "ghanbar");
            // Act
            //Person actual = people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            Person actual = people.FindById(1);
            //Assert.Equal(expected.personId, actual.personId);
            Assert.Equal(expected, actual);
            //Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void Create_()
        {
            // Arrange
            People people;
            Person[] array1;
            array1 = new Person[2];
            array1[0] = new Person(1, "Ali", "Ezadkhaha");           
            array1[1] = new Person(2, "gholi", "ghanbar");
            people = new People(array1);
            Person expected = new Person(2,"gholi","ghanbar");
            // Act
            Person actual = people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");

            // Assert
            Assert.Equal(expected, actual);
            Assert.True(expected.LastName == actual.LastName);            
        }

        [Fact]
        public void Clear_ReturnsTrue()
        {
            People people;            
            Person[] array1;
            array1 = new Person[4];
            array1[0] = new Person(1, "Ali", "Ezadkhaha");
            array1[1] = new Person(2, "Benji", "Ezad");
            array1[2] = new Person(3, "Billy", "Bardhyll");
            array1[3] = new Person(4, "gholi", "ghanbar");
            people = new People(array1);
            people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            people.Clear();
            Assert.Equal(People.personArray, new Person[0]);
        }
        [Fact]
        public void RemovePersonFromArray_()
        {
            // Arrange
            People people;
            Person[] array1;
            array1 = new Person[4];
            people = new People(array1);      
            array1[0]=people.Create(PersonSequencer.nextPersonId(), "gholi", "ghanbar");
            array1[1]=people.Create(PersonSequencer.nextPersonId(), "Benji", "Ezad");
            array1[2]=people.Create(PersonSequencer.nextPersonId(), "Ali", "Ezadkhaha");
            array1[3]=people.Create(PersonSequencer.nextPersonId(), "Billy", "Bardhyll");
            Person[] actual=people.RemovePersonFromPersonArray(array1[3]);
            Assert.True(actual.Contains(array1[3])==false);
        }

    }
}
