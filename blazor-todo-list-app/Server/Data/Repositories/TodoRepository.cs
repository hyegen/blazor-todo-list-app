﻿using blazor_todo_list_app.Entities.Dtos;
using blazor_todo_list_app.Entities.Entities;
using blazor_todo_list_app.Server.Data.Interfaces;
using Context;
using Microsoft.EntityFrameworkCore;

namespace blazor_todo_list_app.Server.Data.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        #region members
        private readonly ToDoContext _todoContext;
        #endregion

        #region constructor
        public TodoRepository(ToDoContext todoContext)
        {
            _todoContext = todoContext;
        }
        #endregion

        #region methods
        public async Task<IEnumerable<Task_>> GetTodos()
        {
            return await _todoContext.Tasks.ToListAsync();
        }
        public async Task<Task_> GetTodoById(int id)
        {
            Task_ task = new Task_();
            task = await _todoContext.Tasks.FindAsync(id);
            return task;
        }
        public async Task<Task_> AddTodo(Task_ todo)
        {
            _todoContext.Tasks.Add(todo);
            await _todoContext.SaveChangesAsync();
            return todo;
        }
        public async Task<Task_> UpdateTodo(Task_ todo)
        {
            _todoContext.Entry(todo).State = EntityState.Modified;
            await _todoContext.SaveChangesAsync();
            return todo;
        }
        public async Task DeleteTodoById(int id)
        {
            var todo = await _todoContext.Tasks.FindAsync(id);
            if (todo != null)
            {
                _todoContext.Tasks.Remove(todo);
                await _todoContext.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<GetAllTaskDto>> GetAllTasksView()
        {
            var result = (from tasks in _todoContext.Tasks
                          select new GetAllTaskDto
                          {
                              Id = tasks.Id,
                              TaskName = tasks.TaskName,
                              Description = tasks.Description,
                              IsCompleted = tasks.IsCompleted
                          });
            return result;
        }
        #endregion
    }
}
