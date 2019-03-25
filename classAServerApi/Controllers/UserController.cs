using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using classAServerApi.Models;

namespace classAServerApi.Controllers
{
    public class UserController : ApiController
    {
        List<User> UsersList = new List<User>()
        {
            new User {UserID =1, UserName = "Naor", City = "MyCity" },
            new User {UserID =2, UserName = "ads", City = "fdf" }
        };

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return UsersList;
        }
        [HttpGet]
        public User getSpecificUSer(int id)
        {
            return UsersList.First();
        }
    }
}
