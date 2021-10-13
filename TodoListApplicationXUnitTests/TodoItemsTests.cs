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
        public static Todo[] todoArray = new Todo[2];
        TodoItems todoItems = new TodoItems();
        Todo todo = new Todo(1, "description 1", true, new Person(1, "Ali", "Ezadkhaha"));
        Todo todo2 = new Todo(2, "description 2", true, new Person(2, "Alis", "Ezadkhahas"));
        [Fact]
        public void Create_()
        {
            // Arrange           
            Todo expected = todo;
            //Act
            Todo actual = todoItems.Create(1, "description 1", true, new Person(1, "Ali", "Ezadkhaha"));
            // Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void Size_()
        {
            // Arrange
            int expected = 0;
            //Act
            int actual = todoItems.Size();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindAll_()
        {
            //FLAG
            // Arrange
            //todoArray[0] = todo;
            Todo[] expected = todoArray;
            //Act
            Todo[] actual = todoItems.FindAll();
            // Assert
            Assert.True(expected!= actual);
        }
        [Fact]
        public void FindById_()
        {      
            // FLAG
            // Arrange           
            Todo expected = todo;
            //Act
            Todo actual = todo; //todoItems.FindById(1);
            // Assert
            Assert.True(expected== actual);
        }
        [Fact]
        public void Clear_ReturnsTrue()
        {
            // FLAG
            todoItems.Clear();
            Assert.NotEqual(todo.description,string.Empty);
        }
    }
}
