using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Model
{
     public class Todo
    {
        public Todo(int todoId, string description, bool done, Person assignee)
        {
            this.todoId = todoId;
            this.description = description;
            this.done = done;
            this.assignee = assignee;
        }

        public int todoId { get; }
        public string description { get; set; }
        public bool done { get; set; }
        public Person assignee { get; set; }
    }
}
