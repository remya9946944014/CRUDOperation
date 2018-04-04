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

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        WorkoutDataLayer dAO = new WorkoutDataLayer();

        [HttpGet,Route("api/Category/GetCategories")]
        public IList<workout_category> GetCategories()
        {
           return dAO.GetCategories();
        }

        [HttpPost,Route("api/Category/AddCategory")]
        public void AddCategory(workout_category obj)
        {
            dAO.AddCategory(obj);            
        }
        /*[HttpPost,Route("api/Category/AddCategory/{id}/{name}")]
        public void AddCategory(int id, string name)
        {
            workout_category obj = new workout_category();
            obj.category_id = id;
            obj.category_name = name;
            dAO.AddCategory(obj);            
        }*/
        [HttpPut, Route("api/Category/UpdateCategory")]
        public void UpdateCategory(workout_category obj)
        {
            dAO.UpdateCategory(obj);
        }
        [HttpDelete, Route("api/Category/DeleteCategory/{id}")]
        public HttpResponseMessage DeleteCategory(int id)
        {
            dAO.DeleteCategory(id);
            return new HttpResponseMessage();
        }

    }
}
