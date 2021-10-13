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
        public People people;
        public Person person1;
        Person[] array1;

        public PeopleTests()
        {
            person1 = new Person(1, "Ali", "Ezadkhaha");
            array1 = new Person[4];
            array1[0] = new Person(1, "Ali", "Ezadkhaha");
            array1[1] = new Person(2, "Benji", "Ezad");
            array1[2] = new Person(3, "Billy", "Bardhyll");
            array1[3] = new Person(4, "Ahmed", "gholi");
            people = new People(array1);
        }
        [Fact]
        public void People_ReturnsTrue()
        {
            Assert.False(people.Size() == 1);
            Assert.True(array1.Length == 4);
        }
        [Fact]
        public void People_FindAll_ReturnsTrue()
        {
            Assert.Equal(array1[0].personId, person1.personId);
            Assert.True(array1.Length == 4);
        }
        [Fact]       
        public void Create_()
        {
            // Arrange
            TodoSequencer todoSequencer = new TodoSequencer();
            Person expected = people.Create(1, "gholi", "ghanbar");
            // Act
            Person actual = people.Create(todoSequencer.NextTodoId(), "gholi", "ghanbar");

            // Assert
            Assert.False(expected==actual);
        }
        //[Fact]
        //public void FindById_ReturnsTrue()
        //{
        //    Person expected = new Person(1, "gholi", "ghanbar");
        //    Person actual = people.FindById(3);
        //    Assert.Equal(expected, actual);
        //}
        //[Fact]
        //public void Clear_ReturnsTrue()
        //{        
        //    Assert.True();
        //}
        //[Fact]
        //public void RemovePersonFromArray_()
        //{
        //    // Arrange
        //    TodoSequencer todoSequencer = new TodoSequencer();
        //    Person expected = people.RemovePersonFromPersonArray(array1[0])[0];
        //    // Act
        //    Person actual = people.Create(todoSequencer.NextTodoId(), "gholi", "ghanbar");

        //    // Assert
        //    Assert.True(expected == actual);
        //}
    }
}
