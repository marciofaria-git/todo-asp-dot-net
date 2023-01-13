using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.Models;

public class TasksModel
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public TaskPriority Priority { get; set; }
    public bool IsCompleted { get; set;}

}

public enum TaskPriority {Low, Medium, High}