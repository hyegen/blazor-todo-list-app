using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazor_todo_list_app.Entities.Entities.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedDate_ { get; set; }
        DateTime? UpdatedDate_ { get; set; }
    }
}
