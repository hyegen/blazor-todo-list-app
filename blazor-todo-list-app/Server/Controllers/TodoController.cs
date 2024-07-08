using blazor_todo_list_app.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Services.Interfaces;

namespace blazor_todo_list_app.Server.Controllers
{

    [Route("api/Todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet("GetTodos")]
        public async Task<ActionResult<IEnumerable<Task_>>> GetTodos()
        {
            return Ok(await _todoService.GetTodos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Task_>> GetTodoById(int id)
        {
            return Ok(await _todoService.GetTodoById(id));
        }

        [HttpPost("AddTodo")]
        public async Task<ActionResult<Task_>> AddTodo(Task_ todo)
        {
            try
            {
                var res = await _todoService.AddTodo(todo);
                return Ok("Basarili");
            }
            catch (Exception ex)
            {
                return BadRequest($"HATA: {ex.Message}");
            }

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Task_>> UpdateTodo(int id, Task_ todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }
            return Ok(await _todoService.UpdateTodo(todo));
        }

        [HttpDelete]
        [Route("DeleteTodo/{id}")]
        public async Task<IActionResult> DeleteTodoById(int id)
        {
            await _todoService.DeleteTodoById(id);
            return Ok("Silme Basarili");
        }
    }
}