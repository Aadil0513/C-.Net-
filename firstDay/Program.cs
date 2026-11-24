
using firstDay.Models;

var task = new TaskItem

{
    
    Id = 1,
    Title = "Complete .NET Day 1 setup",
    IsCompleted = true

};

Console.WriteLine(task.GetSummary());

Console.WriteLine("Hello, World!");

