using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Model;

namespace TodoListApplication.Data
{
    class TodoItems
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
            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].todoId == todoId)
                {
                    return todoArray[i];
                }
            }
            Console.WriteLine("Not found");
            return null;
        }
        public Todo[] Create(int id, string description, bool done,Person assignee)
        {
            TodoSequencer ts = new TodoSequencer();
            Todo todo = new Todo(ts.NextTodoId(), description, done,assignee);
            Todo[] newArray = new Todo[Size() + 1];
            for (int i = 0; i < Size(); i++)
            {
                newArray[i] = todoArray[i];
            }
            newArray[Size()] = todo;
            return newArray;
        }
        public void Clear()
        {
            Array.Clear(todoArray, 0, Size());
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            int count = 0;
            for(int i = 0; i < Size(); i++)
            {
                if (todoArray[i].done == true)
                {
                    count++;
                }
            }
            Todo[] newTodo = new Todo[count];
            for (int i = 0; i < Size(); i++)
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
            for(int i = 0; i < Size(); i++)
            {
                Todo[] todo=new Todo[0];
                if (todoArray[i].assignee.personId == personId)
                {
                    todo[0] = todoArray[i];
                    return todo;
                }
            }
            Console.WriteLine("Not found");
            return null;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            for (int i = 0; i < Size(); i++)
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
            for (int i = 0; i < Size(); i++)
            {
                // null?
                if (todoArray[i].assignee == null)
                {
                    count++;
                }
            }
            Todo[] newTodo = new Todo[count];
            for (int i = 0; i < Size(); i++)
            {
                Todo[] todo = new Todo[0];
                if (todoArray[i].assignee == null)
                {
                    newTodo[i] = todoArray[i];                  
                }
            }
            return newTodo;
        }
    }
}
