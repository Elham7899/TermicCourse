using ErfanTermicCourse.Infrastructure.Entities;

namespace ErfanTermicCourse.Models;

public class TermicCourses : BaseEntity
{
	//Ctor
	private TermicCourses() { }

	private TermicCourses(string name, DateTime startDate, bool isActive)
	{
		Name = name;
		StartDate = startDate;
		IsActive = isActive;
		Status = TermicCourseStatus.OpenCapacity;
	}

	//Props
	public string Name { get; set; }
	public DateTime StartDate { get; set; }
	public bool IsActive { get; set; }
	public TermicCourseStatus Status { get; set; }

	//Methodes
	public static TermicCourses CreateTermicCource(string name, DateTime startDate, bool isActive) => new(name, startDate, isActive);
}

public enum TermicCourseStatus
{
	InProgress = 0,
	OpenCapacity = 1,
	Canceled = 2,
	Started = 3
}