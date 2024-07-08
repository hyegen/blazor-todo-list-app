using blazor_todo_list_app.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace blazor_todo_list_app.Server.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasData(
                    new User() { Id = 1, Username = "YEGEN", Email = "hyegen205@gmail.com" }
                );
        }
    }
}
