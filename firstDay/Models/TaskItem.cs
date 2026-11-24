namespace firstDay.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }

    public string GetSummary()
    {
        string status = IsCompleted ? "Done" : "Pending";
        return $"[{Id}] {Title} - {status}";
    }
}