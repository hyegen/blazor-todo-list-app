using blazor_todo_list_app.Entities.Entities;
using blazor_todo_list_app.Server.Data.Interfaces;
using Services.Interfaces;

namespace blazor_todo_list_app.Server.Services.Concrete
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Task_>> GetTodos()
        {
            return await _repository.GetTodos();
        }

        public async Task<Task_> GetTodoById(int id)
        {
            return await _repository.GetTodoById(id);
        }

        public async Task<Task_> AddTodo(Task_ todo)
        {
            return await _repository.AddTodo(todo);
        }

        public async Task<Task_> UpdateTodo(Task_ todo)
        {
            return await _repository.UpdateTodo(todo);
        }

        public async Task DeleteTodoById(int id)
        {
            await _repository.DeleteTodoById(id);
        }
    }
}
