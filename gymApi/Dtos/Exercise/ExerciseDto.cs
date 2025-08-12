using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gymApi.Dtos.Exercise
{
    public class ExerciseDto
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Equipment { get; set; } = string.Empty;
        public string TargetMuscle { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}