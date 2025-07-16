using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using gymApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gymApi.Controllers
{
    [Route("api/[controller]")]
    public class ExerciseController : ControllerBase
    {
        static private List<Exercise> exercises = new List<Exercise>
        {
            new Exercise
            {
                Id = 1,
                ExerciseName = "Push Up",
                Description = "A basic bodyweight exercise that targets the chest, shoulders, and triceps.",
                Category = "Strength",
                Equipment = "None",
                TargetMuscle = "Chest",
                ImageUrl = "https://example.com/pushup.jpg"
            },
            new Exercise
            {
                Id = 2,
                ExerciseName = "Squat",
                Description = "A fundamental lower body exercise that works the quadriceps, hamstrings, and glutes.",
                Category = "Strength",
                Equipment = "None",
                TargetMuscle = "Legs",
                ImageUrl = "https://example.com/squat.jpg"
            }
        };
        [HttpGet]
        public ActionResult<List<Exercise>> GetExercises()
        {
            return Ok(exercises);
        }
    }
}