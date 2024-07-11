namespace Ilse.InboxConsumer.Domain;

public class InboxEvent
{
    public int Id { get; set; }

    public required string EventType { get; init; }
    public required string Data { get; init; }

    public required string CorrelationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public required string Status { get; set; }

    public required string TenantId { get; set; }

    public override string ToString()
    {
        return
            $"Id: {Id}, EventType: {EventType}, CorrelationId: {CorrelationId}, CreatedAt: {CreatedAt}, Status: {Status}, TenantId: {TenantId}, Data: {Data}";
    }
}
