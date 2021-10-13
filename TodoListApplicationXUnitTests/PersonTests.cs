using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TodoListApplication.Model;


namespace TodoListApplicationXUnit
{   

    public class PersonTests
    {              
         public Person person1;
         public Person person2;
         public Person person3;      
        public PersonTests()
        {
            person1 = new Person(1,"Ali","Ezadkhaha");
            person2 = new Person(4, " ", " ");                    
            person3 = new Person(5, null, null);          
        }
        [Fact]
        public void Name_ReturnsTrue()
        {
            Assert.True(person1.FirstName == "Ali");
            Assert.True(person1.LastName == "Ezadkhaha");
            Assert.True(person1.personId == 1);
        }
        [Fact]
        public void Name_ReturnsEmpty()
        {                      
            Assert.NotNull(person2.FirstName);           
            Assert.NotNull(person2.LastName);          
        }
        [Fact]
        public void Name_ReturnsEqualTrue()
        {
            Assert.True(person2.FirstName==" ");
            Assert.True(person2.LastName== " ");
        }
        [Fact]
        public void Name_ReturnsNull()
        {
            Assert.Null(person3.FirstName);
            Assert.Null(person3.LastName);
        }

    }
}
