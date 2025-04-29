namespace JobTracker.Client.Models;

public record JobApplicationDto
{
    public Guid Id { get; init; }
    public string CompanyName { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public DateTime ApplicationDate { get; init; }
    public string Status { get; init; } = string.Empty;
    public string? Notes { get; init; }
    public string? Url { get; set; }
}
