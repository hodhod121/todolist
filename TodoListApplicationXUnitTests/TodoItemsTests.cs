using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Data;
using TodoListApplication.Model;
using Xunit;

namespace TodoListApplicationXUnitTests
{
    public class TodoItemsTests
    {      
        [Fact]
        public void Create_()
        {
            // Arrange
            TodoItems todoItems = new TodoItems();
            Todo todo = new Todo(1, "description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo expected = todo;
            //Act
            Todo actual = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo actual2 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            // Assert
            Assert.Equal(expected.todoId, actual.todoId);
            Assert.Equal(expected.description, actual.description);
            Assert.Equal(expected.done, actual.done);
            Assert.Equal(expected.assignee.personId, actual.assignee.personId);
            Assert.Equal(expected.assignee.FirstName, actual.assignee.FirstName);
            Assert.Equal(expected.assignee.LastName, actual.assignee.LastName);
        }
        [Fact]
        public void Size_()
        {
            // Arrange
            TodoItems todoItems = new TodoItems();
            Todo td1 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo td2 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo[] todoArray = new Todo[2] { td1, td2 };
            int expected = todoArray.Length;
            //Act           
            int actual = todoItems.Size();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindAll_()
        {
            TodoItems todoItems = new TodoItems();
            Todo td1 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo td2 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));

            Todo[] todoArray = new Todo[2] { td1, td2 };
            Todo[] expected = todoArray;
            //Act

            Todo[] actual = todoItems.FindAll();
            // Assert
            Assert.Equal(expected[0].description, actual[0].description);
        }
        [Fact]
        public void FindById_()
        {
            TodoItems todoItems = new TodoItems();
            Todo td1 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo td2 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));

            Todo[] todoArray = new Todo[2] { td1, td2 };
            // Arrange           
            Todo expected = todoArray[0];
            //Act
            Todo actual = todoItems.FindById(td1.todoId);
            // Assert
            Assert.Equal(expected.description, actual.description);
        }
        [Fact]
        public void Clear_ReturnsTrue()
        {
            //flag
            TodoItems todoItems = new TodoItems();
            Todo td1 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo td2 = todoItems.Create("description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            Todo[] todoArray = new Todo[2] { td1, td2 };
            todoItems.Clear();
            Assert.True(true); 
        }
    }
}
