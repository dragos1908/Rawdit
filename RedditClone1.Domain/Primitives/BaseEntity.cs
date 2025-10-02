namespace RedditClone1.Domain.Primitives;

public abstract class BaseEntity
{
    public Guid Id { get; private init; } =  Guid.NewGuid();
    public DateTimeOffset CreatedAt { get; protected set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; protected set; } 
    
    protected void Touch() => UpdatedAt = DateTimeOffset.UtcNow;
}