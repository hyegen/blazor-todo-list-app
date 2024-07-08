using blazor_todo_list_app.Entities.Dtos;
using blazor_todo_list_app.Entities.Entities;
using blazor_todo_list_app.Server.Data.Interfaces;
using blazor_todo_list_app.Server.Services.Interfaces;
using Services.Interfaces;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Server.Services.Concrete
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;
        private readonly IMailService _mailService;
        public TodoService(ITodoRepository repository, IMailService mailService)
        {
            _repository = repository;
            _mailService = mailService;
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
            var result = await _repository.AddTodo(todo);
            await _mailService.SendEmailAsync("hyegen205@gmail.com", $"Yeni Görev Eklendi - {todo.TaskName}", $"Yeni bir görev eklendi: {todo.Description}");
            return result;
        }
        public async Task<Task_> UpdateTodo(Task_ todo)
        {
            return await _repository.UpdateTodo(todo);
        }
        public async Task DeleteTodoById(int id)
        {
            await _repository.DeleteTodoById(id);
        }
        public async Task<IEnumerable<GetAllTaskDto>> GetAllTasksView()
        {
            return await _repository.GetAllTasksView();
        }
    }
}
