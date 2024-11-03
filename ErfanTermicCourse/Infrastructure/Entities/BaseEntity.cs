namespace ErfanTermicCourse.Infrastructure.Entities;

public class BaseEntity
{
	public long Id { get; set; }
	public bool IsDeleted { get; set; }
	public DateTime CreatedAt { get; } = DateTime.Now;
}