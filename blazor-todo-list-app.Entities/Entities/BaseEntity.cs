using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedDate_ { get; set; } = DateTime.Now;
        public DateTime UpdatedDate_ { get; set; }
    }
}
