using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Entities
{
    public class Comment: BaseEntity
    {
        [Key]
        public int CommentId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }


        public virtual Task_ Task { get; set; }
        public virtual User User { get; set; }
    }

}
