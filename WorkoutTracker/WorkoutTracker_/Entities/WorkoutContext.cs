using System;
using System.Data.Entity;

namespace WorkoutTracker_Datalayer.Entities
{
    public class WorkoutContext:DbContext
    {
        static WorkoutContext()
        {
            Database.SetInitializer<WorkoutContext>(new CreateDatabaseIfNotExists<WorkoutContext>());
        }


    public WorkoutContext() : base("name=workoutconn")
        { }
        public DbSet<workout_active> Workout_active { get; set; }
        public DbSet<workout_category> Workout_category { get; set; }
        public DbSet<workout_collection> Workout_collection { get; set; }
    }
}
