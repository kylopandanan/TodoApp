using TodoApp.Models;

namespace TodoApp.Repository.MsSQL
{
    public class DBRepository: ITodoRepository
    {

        public List<Todo> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        // get any specific todo
        public Todo GetTodoById(int Id)
        {
            throw new NotImplementedException();
        }

        // add todo into the list
        public Todo AddTodo(Todo newTodo)
        {
            throw new NotImplementedException();
        }

        // update todo in the list
        public Todo UpdateTodo(int todoId, Todo newTodo)
        {
            throw new NotImplementedException();
        }

        // delete 
        public Todo DeleteTodo(int todoId)
        {
            throw new NotImplementedException();
        }
    }
}
