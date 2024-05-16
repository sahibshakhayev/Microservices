using System;
using System.Collections.Generic;

namespace TasksService.Data.Model;

public partial class DeletedTask
{
    public int TaskId { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual UserTask Task { get; set; } = null!;
}
