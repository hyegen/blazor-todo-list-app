using blazor_todo_list_app.Common.TaskEnums;
using blazor_todo_list_app.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace blazor_todo_list_app.Server.Config
{
    public class TaskConfig : IEntityTypeConfiguration<Task_>
    {
        public void Configure(EntityTypeBuilder<Task_> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasData(
                    new Task_() { Id = 1, UserId = 1, CommentId = 1, TaskName = "Math Homework", Description = "Math homeworks will be continued.", Status = (int)TaskStatuses.ToDo, CreatedDate_ = DateTime.Now, IsCompleted = false },
                    new Task_() { Id = 2, UserId = 1, CommentId = 2, TaskName = "PHYSC Homework", Description = "Description of PHYSC.", Status = (int)TaskStatuses.Completed, CreatedDate_ = DateTime.Now, IsCompleted = true },
                    new Task_() { Id = 3, UserId = 1, CommentId = 3, TaskName = "Logic Circuits Homework", Description = "Hi from cpu :D.", Status = (int)TaskStatuses.Completed, CreatedDate_ = DateTime.Now, IsCompleted = true },
                    new Task_() { Id = 4, UserId = 1, TaskName = "Go To Super Market", Description = "Buy new meal and others.", Status = (int)TaskStatuses.InProgress, CreatedDate_ = DateTime.Now, IsCompleted = false },
                    new Task_() { Id = 5, UserId = 1, TaskName = "Wash Dishes", Description = "Wash dishes xxxx", Status = (int)TaskStatuses.InProgress, CreatedDate_ = DateTime.Now, IsCompleted = false },
                    new Task_() { Id = 6, UserId = 1, TaskName = "Vacuuming", Description = "Do vacuuming to home for a clean home :).", Status = (int)TaskStatuses.Completed, CreatedDate_ = DateTime.Now, IsCompleted = true }
                );
        }
    }
}
