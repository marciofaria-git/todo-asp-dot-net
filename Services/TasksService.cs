using TodoWebApp.Models;

namespace TodoWebApp.Services;

public static class TaskService
{
    static List<TasksModel> Tasks { get; }
    static int nextId = 3;
    static TaskService()
    {
        Tasks = new List<TasksModel>
        {
            new TasksModel {Id = 1, Name = "Hello i'm a task", Priority = TaskPriority.High, IsCompleted = false},

            new TasksModel {Id = 2, Name = "I am another task", Priority = TaskPriority.Low, IsCompleted = false}
        };

        
    }

    public static List<TasksModel> GetAll() => Tasks;

    public static TasksModel? Get(int id) => Tasks.FirstOrDefault(tasks => tasks.Id == id);

    public static void Add(TasksModel tasks)
    {
        tasks.Id = nextId++;
        
    }

    public static void Delete(int id)
    {
        var task = Get(id);
        if (task is null)
        return;

        Tasks.Remove(task);
    }

    public static void Update(TasksModel tasks)
    {
        var index = Tasks.FindIndex(task => task.Id == tasks.Id);
        if(index == -1)
        return;

        Tasks[index] = tasks;
    }

}