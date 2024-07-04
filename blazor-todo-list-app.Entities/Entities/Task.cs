using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blazor_todo_list_app.Entities.Entities
{
    public class Task_ : BaseEntity
    {
        [Key]
        public int TaskId { get; set; } 
        public int ProjectId { get; set; } 
        public string TaskName { get; set; }
        public string Description { get; set; } 
        public string Status { get; set; } 
        public string Priority { get; set; } 

        public virtual ICollection<SubTask> Subtasks { get; set; } 
        public virtual ICollection<Comment> Comments { get; set; } 
    }
}
