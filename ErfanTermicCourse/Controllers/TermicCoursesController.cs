using ErfanTermicCourse.Models.DTOs;
using ErfanTermicCourse.Services.TermicCoursesServices;
using Microsoft.AspNetCore.Mvc;

namespace ErfanTermicCourse.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TermicCoursesController(ITermicCourseService termicService) : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> Create(TermicCourseDTO termicCourseDTO)
		{
			await termicService.AddTermicCourseAsync(termicCourseDTO);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> Get(long id)
		{
			await termicService.GetByAsync(id);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			await termicService.GetAllAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> Delete(long id)
		{
			await termicService.DeleteTermicCourseAsync(id);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> Update(TermicCourseDTO termicCourseDTO)
		{
			await termicService.UpdateTermicCourseAsync(termicCourseDTO);
			return Ok();
		}
	}
}
