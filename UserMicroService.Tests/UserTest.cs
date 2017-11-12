using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMicroService.DataAccess;
using UserMicroService.Models;
using UserMicroService.Util;

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
            ClearUsers();
            User testUser = new User
            {

                Id = 1,
                Name = "Marko"

            };

            UserDB.AddNewUser(testUser);
            Assert.AreEqual(1, UserDB.listOfUsers.Count);
        }

        [Test]
        public void Remove_User_Success()
        {
            ClearUsers();
            User testUser = new User
            {
                Id = 1,
                Name = "Marko"
            };

            UserDB.AddNewUser(testUser);
            UserDB.RemoveUser(testUser.Id);
            Assert.AreEqual(0, UserDB.listOfUsers.Count);

        }

        [Test]
        public void Remove_User_Fail()
        {
            ClearUsers();
            User testUser = new User
            {
                Id = 1,
                Name = "Marko"
            };
            UserDB.AddNewUser(testUser);
            UserDB.RemoveUser(2);

            Assert.AreEqual(1, UserDB.listOfUsers.Count);
        }
        [Test]
        public void GetAllUsers_Success()
        {
            ClearUsers();
            User testUser1 = new User
            {
                Id = 1,
                Name = "Marina"
            };
            User testUser2 = new User
            {
                Id = 2,
                Name = "Marija"
            };
            User testUser3 = new User
            {
                Id = 3,
                Name = "Ksenija"
            };
            UserDB.AddNewUser(testUser1);
            UserDB.AddNewUser(testUser2);
            UserDB.AddNewUser(testUser3);
            Assert.AreEqual(3, UserDB.GetAllUsers().Count);

        }
        [Test]
        public void GetUserById_Success()
            {
                ClearUsers();
                User testUser = new User
                {
                    Id = 1,
                    Name = "Marko"
                };
                UserDB.AddNewUser(testUser);
                Assert.AreEqual(testUser, UserDB.GetUserById(1));

            }
        
        [Test]
        public void GetUserByName_Success()
        {
            ClearUsers();
            User testUser = new User
            {
                Id = 1,
                Name = "Marko"

            };

            UserDB.AddNewUser(testUser);
            Assert.AreEqual(1, UserDB.GetUserByName("Marko").Count);

        }

        [Test]
        public void GetUserByName_Fail()
        {
            ClearUsers();
            User testuser = new User
            {
                Id = 1,
                Name = "Marko"
            };
            UserDB.AddNewUser(testuser);
            Assert.AreEqual(null, UserDB.GetUserByName("Marina"));
        }
        [Test]
        public void ModifyUser_Success()
        {
            ClearUsers();
            User testUser = new User
            {
                Id = 1,
                Name = "Marko",

            };
            UserDB.AddNewUser(testUser);

            UserDB.ModifyUser(testUser.Id, "Marija", testUser.Email, testUser.Adresa, testUser.ZipCode, testUser.CityName, testUser.CountryName, testUser.Phone);
            Assert.AreEqual(1, UserDB.GetUserByName("Marija").Count);


        }


    }
}

