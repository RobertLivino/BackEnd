using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gymApi.Dtos.Exercise;
using gymApi.Models;

namespace gymApi.Mappers
{
    public static class ExerciseMappers
    {
        public static ExerciseDto ToExerciseDto(this Exercise exerciseModel)
        {
            if (exerciseModel == null) return null;

            return new ExerciseDto
            {
                Id = exerciseModel.Id,
                ExerciseName = exerciseModel.ExerciseName,
                Description = exerciseModel.Description,
                Category = exerciseModel.Category,
                Equipment = exerciseModel.Equipment,
                TargetMuscle = exerciseModel.TargetMuscle,
                ImageUrl = exerciseModel.ImageUrl
            };
        }
        public static Exercise ToExerciseFromCreateDto(this CreateExerciseRequestDto exerciseModel)
        {
            return new Exercise
            {
                ExerciseName = exerciseModel.ExerciseName,
                Description = exerciseModel.Description,
                Category = exerciseModel.Category,
                Equipment = exerciseModel.Equipment,
                TargetMuscle = exerciseModel.TargetMuscle
            };
        }
    }
}