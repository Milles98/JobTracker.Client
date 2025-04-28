namespace JobTracker.Client.Models;

public class UpdateJobRequest
{
    public string Status { get; set; } = string.Empty;
    public string? Notes { get; set; }
}
