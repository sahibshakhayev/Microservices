using System;
using System.Collections.Generic;

namespace TasksService.Data.Model;

public partial class UserTask
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string Status { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public virtual CompletedTask? CompletedTask { get; set; }

    public virtual DeletedTask? DeletedTask { get; set; }
}
