using DemoTodoListClient.ToDoListService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTodoListClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoListService.TodoListServiceClient obj = new ToDoListService.TodoListServiceClient("WSHttpBinding_ITodoListService");

            ToDoItem tt= obj.GetItem().First();

            Console.WriteLine(tt.Tittle + " "+ tt.Description);
            Console.ReadLine();
        }
    }
}
