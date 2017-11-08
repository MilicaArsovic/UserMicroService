using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;

namespace UserMicroService.DataAccess
{ // staticka lista user-a , pronalazenje user-a po idu u toj listi...
   
    public static class UserDB
    {
        public static List<User> listOfUsers = new List<User>();

        public static List<User> GetAllUsers() {
           return listOfUsers; //vracanje svih korisnika
        }
        public static User GetUserById(int id) { 
            foreach (User u in listOfUsers) {
                if (u.Id == id) {
                    return u;
                }
            }
            return null;
        }

       

        public static User GetUserByName(string name) {
            foreach (User u in listOfUsers) {
                if (u.Name == name) {
                    return u;
                }
            }
            return null;
        }
        public static User AddNewUser(User user) {
            listOfUsers.Add(user);
            return GetUserById(user.Id);
        }
    }
}