using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using UserMicroService.DataAccess;
using UserMicroService.Models;

namespace UserMicroService.Controllers
{
    public class UserControllers
    {
        /// <summary>
        /// Gets single user by id
        /// </summary>
        /// <param name = "id"> User id</param>
        /// <returns>Single user</returns>


        public class UserController : ApiController
        {
            [Route("api/User/{id}"), HttpGet] //{id} --- parametar koji se prosledjuje // prekopirati u Postman, prvo adresu koja se pojavi nakon pokretanja (Google Chrome) , za id staviti 1 (ili bilo koji broj)
            public User GetUserById(int id)
            {
                return UserDB.GetUserById(id);
            }
        }

    }
}