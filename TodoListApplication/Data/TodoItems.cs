using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Model;

namespace TodoListApplication.Data
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];
        public int Size()
        {
            return todoArray.Length;
        }
        public Todo[] FindAll()
        {
            return todoArray;
        }
        public Todo FindById(int todoId)
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].todoId == todoId)
                {
                    return todoArray[i];
                }
            }
            return null;
        }
        public Todo Create(string description, bool done, Person assignee)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description, done, assignee);
            Todo[] newArray = new Todo[todoArray.Length + 1];
            for (int i = 0; i < todoArray.Length; i++)
            {
                newArray[i] = todoArray[i];
            }
            newArray[todoArray.Length] = todo;
            todoArray = newArray;
            return todo;
        }
        public void Clear()
        {
            Array.Clear(todoArray, 0, todoArray.Length);
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            int count = 0;
            // Toddo[] result = new Todo[];
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].done == true) // doneStatus..? ist för true
                {
                    //Array.Resize(result, result.Length +1);
                    //result[result.Length +1] = todoArrayi];
                    count++;
                }
            }
            Todo[] newTodo = new Todo[count];
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].done == true)
                {
                    newTodo[i] = todoArray[i];
                }
            }
            return newTodo;
        }
        public Todo[] FindByAssignee(int personId)
        {
            int count = 0;
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].assignee.personId == personId)
                {
                    count++;
                }
            }
            int counter = 0;
            Todo[] todo = new Todo[count];
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].assignee.personId == personId)
                {
                    todo[counter] = todoArray[i];
                    counter++;
                }
            }
            if (todo.Length > 0)
            {
                return todo;
            }
            else
            {
                return null;
            }
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                Todo[] todo = new Todo[0];
                if (todoArray[i].assignee == assignee)
                {
                    todo[0] = todoArray[i];
                    return todo;
                }
            }
            Console.WriteLine("Not found");
            return null;
        }
        public Todo[] FindUnassignedTodoItems()
        {
            int count = 0;
            for (int i = 0; i < todoArray.Length; i++)
            {
                // null?
                if (todoArray[i].assignee == null)
                {
                    count++;
                }
            }
            Todo[] newTodo = new Todo[count];
            for (int i = 0; i < todoArray.Length; i++)
            {
                Todo[] todo = new Todo[0];
                if (todoArray[i].assignee == null)
                {
                    newTodo[i] = todoArray[i];
                }
            }
            if (newTodo.Length > 0)
            {
                return newTodo;
            }
            else
            {
                Console.WriteLine("not found");
                return null;
            }
        }
        public Todo[] RemoveTodoFromTodoArray(Todo todo)
        {
            Todo[] newTodo = new Todo[todoArray.Length - 1];
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i] != todo)
                {
                    newTodo[i] = todoArray[i];
                }
            }
            if (newTodo.Length > 0)
            {
                return newTodo;
            }
            else
            {
                Console.WriteLine("Not found");
                return null;
            }
        }
    }
}
