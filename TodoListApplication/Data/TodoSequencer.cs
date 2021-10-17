using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Data
{
     public class TodoSequencer
    {

        private static int todoId;
        public static int NextTodoId()
        {
            return ++todoId;
        }
        public static int Reset()
        {
            todoId = 0;
            return todoId;
        }
    }
}
