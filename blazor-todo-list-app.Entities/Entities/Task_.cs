using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blazor_todo_list_app.Entities.Entities
{
    public class Task_ : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public int? CommentId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<SubTask> Subtasks { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
