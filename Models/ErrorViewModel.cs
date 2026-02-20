namespace Mission5Assignment.Models;

public class ErrorViewModel
{
    // Trace identifier from ASP.NET Core request context.
    public string? RequestId { get; set; }

    // View helper: only render the request ID block when a value exists.
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
