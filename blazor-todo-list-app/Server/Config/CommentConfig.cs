using blazor_todo_list_app.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace blazor_todo_list_app.Server.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasData(
                   new Comment { Id = 1, TaskId = 1, UserId = 1, CommentText = "(Task 1)What a nice Task Maaaan" },
                   new Comment { Id = 2, TaskId = 2, UserId = 1, CommentText = "(Task 2)What a nice Task Maaaan" },
                   new Comment { Id = 3, TaskId = 3, UserId = 1, CommentText = "(Task 3)What a nice Task Maaaan" }
                );
        }
    }
}
