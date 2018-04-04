using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker_Datalayer.Entities
{
    public class workout_collection
    {
        [Key]
        public int workout_id { get; set; }
        [MaxLength(128)]
        public string workout_title { get; set; }
        [MaxLength(256)]
        public string note { get; set; }
        public float calories_burn_min { get; set; }

        [ForeignKey("Workout_category")]
        public int category_id { get; set; }
        public workout_category Workout_category { get; set; }
    }
}
