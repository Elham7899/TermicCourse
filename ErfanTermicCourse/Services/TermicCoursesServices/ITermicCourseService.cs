using ErfanTermicCourse.Models.DTOs;

namespace ErfanTermicCourse.Services.TermicCoursesServices;

public interface ITermicCourseService
{
	void AddTermicCourse(TermicCourseDTO termicCourseDTO);
	Task AddTermicCourseAsync(TermicCourseDTO termicCourseDTO);
	void DeleteTermicCourse(long id);
	Task DeleteTermicCourseAsync(long id);
	void SoftDeleteTermicCourse(long termicCourseId);
	void UpdateTermicCourse(TermicCourseDTO termicCourseDTO);
	Task UpdateTermicCourseAsync(TermicCourseDTO termicCourseDTO);
	TermicCourseDTO GetBy(long termicCourseId);
	Task<TermicCourseDTO> GetByAsync(long termicCourseId);
	List<TermicCourseDTO> GetAll();
	Task<List<TermicCourseDTO>> GetAllAsync();
}