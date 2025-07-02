using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using School.Application.DTOs;
//using School.Application.Interfaces;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Roles = "Teacher,SuperAdmin,Principal")]
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        //private readonly ITeacherService _teacherService;

        //public TeacherController(ITeacherService teacherService)
        //{
        //    _teacherService = teacherService;
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetTeacherById(Guid id)
        //{
        //    var teacher = await _teacherService.GetByIdAsync(id);
        //    return Ok(teacher);
        //}

        //[HttpPost]
        //[Authorize(Roles = "SuperAdmin,Principal")]
        //public async Task<IActionResult> CreateTeacher([FromBody] TeacherDto dto)
        //{
        //    var result = await _teacherService.CreateAsync(dto);
        //    return Ok(result);
        //}

        //[HttpPut("{id}")]
        //[Authorize(Roles = "SuperAdmin,Principal")]
        //public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] TeacherDto dto)
        //{
        //    var result = await _teacherService.UpdateAsync(id, dto);
        //    return Ok(result);
        //}

        //[HttpDelete("{id}")]
        //[Authorize(Roles = "SuperAdmin")]
        //public async Task<IActionResult> DeleteTeacher(Guid id)
        //{
        //    await _teacherService.DeleteAsync(id);
        //    return NoContent();
        //}
    }
}
