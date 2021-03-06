using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Data;
using Xunit;

namespace TodoListApplicationXUnitTests
{
    public class TodoSequencerTests
    {
        public TodoSequencer todoSequencer;
        public TodoSequencerTests()
        {                     
            todoSequencer = new TodoSequencer();
        }
        [Fact]
        public void People_ReturnsTrue()
        {           
            Assert.True(TodoSequencer.NextTodoId()== 1);
            Assert.False(TodoSequencer.NextTodoId()== 1);
            Assert.True(TodoSequencer.Reset() == 0);
        }
    }
}
