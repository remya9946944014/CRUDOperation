using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker_Datalayer.Entities
{
    public class workout_active
    {

        public TimeSpan? start_time { get; set; }
        public DateTime? start_date { get; set; }
        public TimeSpan? end_time { get; set; }
        public DateTime? end_date { get; set; }
        [MaxLength(64)]
        public string comment { get; set; }
        public bool status { get; set; }
        [Key]
        [ForeignKey("Workout_collection")]
        public int workout_id { get; set; }
        public workout_collection Workout_collection { get; set; }
    }
}
