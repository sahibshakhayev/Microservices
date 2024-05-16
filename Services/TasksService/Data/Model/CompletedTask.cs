using System;
using System.Collections.Generic;

namespace TasksService.Data.Model;

public partial class CompletedTask
{
    public int TaskId { get; set; }

    public DateTime? CompletedAt { get; set; }

    public virtual UserTask Task { get; set; } = null!;
}
