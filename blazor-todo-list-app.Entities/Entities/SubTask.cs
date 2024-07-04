using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Entities
{
    public class SubTask : BaseEntity
    {
        [Key]
        public int SubtaskId { get; set; }
        public int TaskId { get; set; }
        public string SubtaskName { get; set; }
        public string Status { get; set; }


        public virtual Task_ Task { get; set; }
    }

}
