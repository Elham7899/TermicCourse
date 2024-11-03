using ErfanTermicCourse.Infrastructure.Repositories;
using ErfanTermicCourse.Models;
using ErfanTermicCourse.Models.DTOs;

namespace ErfanTermicCourse.Services.TermicCoursesServices;

public class TermicCoursesService : ITermicCourseService
{
	public TermicCoursesService(IRepository<TermicCourses> termicCourses)
	{
		_termicCourseRepository = termicCourses;
	}

	private readonly IRepository<TermicCourses> _termicCourseRepository;

	public void AddTermicCourse(TermicCourseDTO termicCourseDTO) =>
		_termicCourseRepository.Add(TermicCourses.CreateTermicCource(termicCourseDTO.Name, termicCourseDTO.StartDate, termicCourseDTO.IsActive));

	public async Task AddTermicCourseAsync(TermicCourseDTO termicCourseDTO) =>
		await _termicCourseRepository.AddAsync(TermicCourses.CreateTermicCource(termicCourseDTO.Name, termicCourseDTO.StartDate, termicCourseDTO.IsActive));

	public void DeleteTermicCourse(long id)
	{
		var termicCourse = _termicCourseRepository.GetById(id);
		_termicCourseRepository.Delete(termicCourse);
	}

	public async Task DeleteTermicCourseAsync(long id)
	{
		var termicCourse = _termicCourseRepository.GetById(id);
		await _termicCourseRepository.DeleteAsync(termicCourse);
	}

	public void SoftDeleteTermicCourse(long termicCourseId)
	{
		var termicCourse = _termicCourseRepository.GetById(termicCourseId);
		_termicCourseRepository.SoftDelete(termicCourse);
	}

	public void UpdateTermicCourse(TermicCourseDTO termicCourseDTO)
	{
		var termicCourse = TermicCourses.CreateTermicCource(termicCourseDTO.Name, termicCourseDTO.StartDate, termicCourseDTO.IsActive);
		_termicCourseRepository.Update(termicCourse);
	}

	public async Task UpdateTermicCourseAsync(TermicCourseDTO termicCourseDTO)
	{
		var termicCourse = TermicCourses.CreateTermicCource(termicCourseDTO.Name, termicCourseDTO.StartDate, termicCourseDTO.IsActive);
		await _termicCourseRepository.UpdateAsync(termicCourse);
	}

	public TermicCourseDTO GetBy(long termicCourseId)
	{
		var termicCourse = _termicCourseRepository.GetById(termicCourseId);
		return Map(termicCourse);
	}

	public async Task<TermicCourseDTO> GetByAsync(long termicCourseId)
	{
		var termicCourse = await _termicCourseRepository.GetByIdAsync(termicCourseId);
		return Map(termicCourse);
	}

	public List<TermicCourseDTO> GetAll()
	{
		var termicCourses = _termicCourseRepository.GetAll();
		return MapToList(termicCourses);
	}

	public async Task<List<TermicCourseDTO>> GetAllAsync()
	{
		var termicCourses = await _termicCourseRepository.GetAllAsync();
		return MapToList(termicCourses);
	}

	private TermicCourseDTO Map(TermicCourses termicCourse)
	{
		return new TermicCourseDTO
		{
			Name = termicCourse.Name,
			IsActive = termicCourse.IsActive,
			StartDate = termicCourse.StartDate,
			Status = termicCourse.Status
		};
	}

	private List<TermicCourseDTO> MapToList(List<TermicCourses> termicCourses) =>
		 termicCourses.Select(a => Map(a)).ToList();

}