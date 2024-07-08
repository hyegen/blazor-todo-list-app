using blazor_todo_list_app.Entities.Dtos;
using blazor_todo_list_app.Entities.Entities;

namespace Services.Interfaces
{
    public interface ITodoService
    {
        Task<IEnumerable<Task_>> GetTodos();
        Task<Task_> GetTodoById(int id);
        Task<Task_> AddTodo(Task_ todo);
        Task<Task_> UpdateTodo(Task_ todo);
        Task DeleteTodoById(int id);
        Task<IEnumerable<GetAllTaskDto>> GetAllTasksView();
    }
}
