using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Data;
using TodoListApplication.Model;
using Xunit;

namespace TodoListApplicationXUnit
{
    public class PeopleTests
    {
        public People people;
        Person[] array1;        

        public PeopleTests()
        {
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
            Assert.True(people.Size() == 0);          
            Assert.True(array1.Length==4);
        }
    }
}
