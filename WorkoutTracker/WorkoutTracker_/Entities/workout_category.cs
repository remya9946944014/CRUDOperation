using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker_Datalayer.Entities
{
    public class workout_category
    {
        [Key]
        public int category_id { get; set; }
        [MaxLength(64)]
        public string category_name { get; set; }
        public ICollection<workout_collection> Workout_collection { get; set; }
    }
}
