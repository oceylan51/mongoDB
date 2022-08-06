using Data.UnitOfWork;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.Web;
using MongoDB.Bson;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MylibaController : ControllerBase
    {
        private readonly UnitOfWork _rUnitOfWork;

        public MylibaController()
        {
            _rUnitOfWork = new UnitOfWork();
        }
        [HttpGet]
        //public HttpResponseMessage Get()
        //{
        //    //var restaurants = _rUnitOfwork.Restaurant.GetAll().AsQueryable();
        //    var restaurants = _rUnitOfWork.Users.GetAll().Result.AsQueryable();
        //    if (restaurants != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, restaurants);
        //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No restaurant found.");
        //}
        public Task<IEnumerable<Users>> GetAll()
        {
            var users = _rUnitOfWork.Users.GetAll();
            return users;
        }
        [HttpPost]
        public async Task Post([FromBody] Users users)
        {
            await _rUnitOfWork.Users.Add(users);
        }
    }
}
