using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturersController : ControllerBase
    {
        ILecturerService _lecturerService;

        public LecturersController(ILecturerService lecturerService)
        {
            _lecturerService = lecturerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _lecturerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("age")]
        public IActionResult GetByAge(int age)
        {
            var result = _lecturerService.GetByAge(age);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Lecturer lecturer)
        {
            var result = _lecturerService.Add(lecturer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
