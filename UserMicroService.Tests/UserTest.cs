using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMicroService.DataAccess;
using UserMicroService.Models;

namespace UserMicroService.Tests
{
    public class UserTest
    {

        public void ClearUsers()
        {
            UserDB.listOfUsers.Clear();
        }
        [Test]
        public void Create_User_Success()
        {
            User testUser = new User
            {

                Id = 1,
                Name = "Marko"

            };

            UserDB.AddNewUser(testUser);
            Assert.AreEqual(1, UserDB.listOfUsers.Count);
        }
    }
}
