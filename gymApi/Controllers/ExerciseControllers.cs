using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gymApi.Data;
using gymApi.Dtos.Exercise;
using gymApi.Mappers;
using gymApi.Models;
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
            var exercises = _context.Exercises.ToList().Select(s => s.ToExerciseDto());
            return Ok(exercises);
        }
        [HttpGet("{id}")]
        public IActionResult GetExerciseById(int id)
        {
            var exercise = _context.Exercises.Find(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(exercise.ToExerciseDto());
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateExerciseRequestDto exerciseDtos)
        {
            var exerciseModel = exerciseDtos.ToExerciseFromCreateDto();
            _context.Exercises.Add(exerciseModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetExerciseById), new { id = exerciseModel.Id }, exerciseModel.ToExerciseDto());
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateExerciseRequestDto updateDtos)
        {
            var exerciseModel = _context.Exercises.Find(id);
            if (exerciseModel == null)
            {
                return NotFound();
            }
            exerciseModel.ExerciseName = string.IsNullOrEmpty(updateDtos.ExerciseName) ? exerciseModel.ExerciseName : updateDtos.ExerciseName;
            exerciseModel.Description = string.IsNullOrEmpty(updateDtos.Description) ? exerciseModel.Description : updateDtos.Description;
            exerciseModel.Category = string.IsNullOrEmpty(updateDtos.Category) ? exerciseModel.Category : updateDtos.Category;
            exerciseModel.Equipment = string.IsNullOrEmpty(updateDtos.Equipment) ? exerciseModel.Equipment : updateDtos.Equipment;
            exerciseModel.TargetMuscle = string.IsNullOrEmpty(updateDtos.TargetMuscle) ? exerciseModel.TargetMuscle : updateDtos.TargetMuscle;
            exerciseModel.ImageUrl = string.IsNullOrEmpty(updateDtos.ImageUrl) ? exerciseModel.ImageUrl : updateDtos.ImageUrl;

            _context.SaveChanges();
            return Ok(exerciseModel.ToExerciseDto());
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var exerciseModel = _context.Exercises.Find(id);
            if (exerciseModel == null)
            {
                return NotFound();
            }
            _context.Exercises.Remove(exerciseModel);
            _context.SaveChanges();
            return NoContent();
        }

    }
}