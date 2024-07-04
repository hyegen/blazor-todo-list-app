using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blazor_todo_list_app.Entities.Entities
{
    public class User: BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
