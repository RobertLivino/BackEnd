using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gymApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace gymApi.Controllers
{
    [ApiController]
    [Route("api/Exercises")]
    public class ExerciseControllers : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ExerciseControllers(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetExercises()
        {
            var exercises = _context.Exercises.ToList();
            return Ok(exercises);
        }
        [HttpGet("{id}")]
        public IActionResult GetExercise(int id)
        {
            var exercise = _context.Exercises.Find(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(exercise);
        }
    }
}