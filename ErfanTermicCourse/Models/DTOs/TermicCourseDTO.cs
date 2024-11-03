namespace ErfanTermicCourse.Models.DTOs
{
	public class TermicCourseDTO
	{
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public bool IsActive { get; set; }
		public TermicCourseStatus Status { get; set; }
	}
}