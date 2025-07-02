using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using School.Application.DTOs;
//using School.Application.Interfaces;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Roles = "Teacher,Principal,SuperAdmin")]
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
    //    private readonly IAttendanceService _attendanceService;

    //    public AttendanceController(IAttendanceService attendanceService)
    //    {
    //        _attendanceService = attendanceService;
    //    }

    //    [HttpPost("mark")]
    //    public async Task<IActionResult> MarkAttendance([FromBody] AttendanceDto dto)
    //    {
    //        var result = await _attendanceService.MarkAttendanceAsync(dto);
    //        return Ok(result);
    //    }

    //    [HttpGet("student/{studentId}")]
    //    public async Task<IActionResult> GetStudentAttendance(Guid studentId)
    //    {
    //        var result = await _attendanceService.GetByStudentAsync(studentId);
    //        return Ok(result);
    //    }

    //    [HttpGet("class/{classId}")]
    //    public async Task<IActionResult> GetClassAttendance(Guid classId)
    //    {
    //        var result = await _attendanceService.GetByClassAsync(classId);
    //        return Ok(result);
    //    }
    //}
}
