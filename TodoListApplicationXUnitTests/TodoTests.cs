using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Model;
using Xunit;

namespace TodoListApplicationXUnit
{
    public class TodoTests
    {
        public Person person1;
        public Person person2;
        public Person person3;
        public Todo todo1;
        public Todo todo2;
        public Todo todo3;
        public TodoTests()
        {
            person1 = new Person(1, "Ali", "Ezadkhaha");
            person2 = new Person(2, " ", " ");
            person3 = new Person(3, null, null);
            todo1 = new Todo(1,"description 1",true,person1);
            todo2 = new Todo(2,"",false,person2);
            todo3 = new Todo(3,null,false,person3);
        }
        [Fact]
        public void Todo_ReturnsTrue()
        {
            Assert.True(todo1.assignee.personId == 1);
            Assert.True(todo1.assignee.FirstName == "Ali");
            Assert.True(todo1.assignee.LastName == "Ezadkhaha");
            Assert.True(todo1.todoId == 1);
            Assert.True(todo1.description == "description 1");
            Assert.True(todo1.done == true);           
        }
        [Fact]
        public void Todo_ReturnsEmpty()
        {
            Assert.NotNull(todo2.description);
            Assert.NotNull(todo2.assignee.FirstName);
            Assert.NotNull(todo2.assignee.LastName);
        }
        [Fact]
        public void Todo_ReturnsEqualTrue()
        {
            Assert.True(todo1.done == true);
            Assert.True(todo2.done == false);
            Assert.True(todo3.done == false);
            Assert.True(todo2.description == "");
            Assert.True(todo3.description == null);
            Assert.True(todo3.todoId == 3);
            Assert.True(todo3.assignee.FirstName == null);
            Assert.True(todo3.assignee.LastName == null);

        }
        [Fact]
        public void Name_ReturnsNull()
        {
            Assert.Null(todo3.description);
            Assert.Null(todo3.assignee.FirstName);
            Assert.Null(todo3.assignee.LastName);
        }
    }
}
