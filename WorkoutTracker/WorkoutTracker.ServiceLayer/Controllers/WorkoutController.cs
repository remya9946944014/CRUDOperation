using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WorkoutTracker_Datalayer;
using WorkoutTracker_Datalayer.Entities;
namespace WorkoutTracker.ServiceLayer.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class WorkoutController : ApiController
    {
        WorkoutDataLayer dAO = new WorkoutDataLayer();
        [HttpGet, Route("api/Workout/GetAllWorkOutCollection")]
        public IList<workout_collection> GetAllWorkoutcollection()
        {
            return dAO.GetWorkoutDetails();
        }
        [HttpPost, Route("api/Workout/AddWorkoutcollection")]
        public void AddWorkoutcollection(workout_collection obj)
        {
            dAO.SaveWorkout(obj);
        }
        [HttpPut, Route("api/Workout/UpdateCategory")]
        public void UpdateWorkoutcollection(workout_collection obj)
        {
            dAO.UpdateWorkout(obj);
        }
        [HttpDelete, Route("api/Workout/DeleteCategory")]
        public HttpResponseMessage DeleteWorkoutcollection(workout_collection obj)
        {
            dAO.DeleteWorkout(obj);
            return new HttpResponseMessage();
        }
    }
}
