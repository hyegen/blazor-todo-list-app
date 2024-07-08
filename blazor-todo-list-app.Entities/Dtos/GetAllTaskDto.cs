using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Dtos
{
    public class GetAllTaskDto
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
