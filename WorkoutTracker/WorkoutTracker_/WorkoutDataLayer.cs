using System.Collections.Generic;
using System.Linq;
using WorkoutTracker_Datalayer.Entities;
namespace WorkoutTracker_Datalayer
{
    public class WorkoutDataLayer
    {
        WorkoutContext obj = new Entities.WorkoutContext();
        public List<workout_category> GetCategories()
        {
            List<workout_category> resultList = new List<workout_category>();
            using (var ctx = new WorkoutContext())
            {
                resultList = ctx.Workout_category.ToList();
            }
            return resultList;
        }
        public void AddCategory(workout_category obj)
        {
            //workout_category obj = new workout_category() { category_id = 12, category_name = "test" };
            using (var ctx = new WorkoutContext())
            {
                ctx.Workout_category.Add(obj);
                ctx.SaveChanges();
            }
        }
        public void UpdateCategory(workout_category newobj)
        {
            using (var ctx = new WorkoutContext())
            {
                workout_category obj = ctx.Workout_category.SingleOrDefault(i => i.category_id == newobj.category_id);
                obj.category_name = newobj.category_name;                
                ctx.SaveChanges();
            }
        }
        public void DeleteCategory(int  id)
        {
            using (var ctx = new WorkoutContext())
            {
                workout_category obj = ctx.Workout_category.SingleOrDefault(x => x.category_id == id);
                ctx.Workout_category.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public List<workout_collection> GetWorkoutDetails()
        {
            List<workout_collection> resultList = new List<workout_collection>();
            using (var ctx = new WorkoutContext())
            {
                resultList = ctx.Workout_collection.ToList();
            }
            return resultList;
        }
        public void SaveWorkout(Entities.workout_collection obj)
        {
            using (var ctx = new WorkoutContext())
            {
                ctx.Workout_collection.Add(obj);
                ctx.SaveChanges();
            }
        }
        public void UpdateWorkout(Entities.workout_collection newobj)
        {
            using (var ctx = new WorkoutContext())
            {
                workout_collection obj = ctx.Workout_collection.SingleOrDefault(i => i.workout_id == newobj.workout_id);
                obj.workout_title = newobj.workout_title;
                obj.Workout_category = newobj.Workout_category;
                obj.calories_burn_min = newobj.calories_burn_min;
                obj.note = newobj.note;
                ctx.SaveChanges();
            }
        }
        public void DeleteWorkout(Entities.workout_collection obj)
        {
            using (var ctx = new WorkoutContext())
            {

                ctx.Workout_collection.Remove(obj);
                ctx.SaveChanges();
            }

        }
        public void StartActive(workout_active obj)
        {
            using (var ctx = new WorkoutContext())
            {
                ctx.Workout_active.Add(obj);
                ctx.SaveChanges();
            }
        }
        public void EndActive(workout_active newObj)
        {
            using (var ctx = new WorkoutContext())
            {
                workout_active obj = ctx.Workout_active.SingleOrDefault(i => i.status == true);
                obj.end_date = newObj.end_date;
                obj.end_time = newObj.end_time;
                ctx.SaveChanges();
            }
        }
    }
}
