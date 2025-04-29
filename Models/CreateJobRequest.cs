namespace JobTracker.Client.Models;

public class CreateJobRequest
{
    public string CompanyName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public string? Url { get; set; }
}
