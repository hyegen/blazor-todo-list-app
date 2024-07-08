using blazor_todo_list_app.Entities.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate_ { get; set; }
        public DateTime? UpdatedDate_ { get; set; }
    }
}
