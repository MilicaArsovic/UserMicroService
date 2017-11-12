using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;
using UserMicroService.Util;

namespace UserMicroService.DataAccess
{
   
    public static class UserDB
    {
        //lista svih korisnika
        public static List<User> listOfUsers = new List<User>();

        //vraca sve korisnike                           
        public static List<User> GetAllUsers()
        {
           return listOfUsers; 
        }

        //vraca korisnika po Id
        public static User GetUserById(int id)
        { 
            foreach (User u in listOfUsers)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }

            Console.WriteLine("No user found!");
            return null;
        }

        public static void RemoveUser(User testUser)
        {
            throw new NotImplementedException();
        }


        //vraca korisnike po imenu
        public static List<User> GetUserByName(string name)
        {
            List<User> userByName = new List<User>();
            foreach (User user in listOfUsers)
            {
                if (user.Name.Equals(name))
                {
                    userByName.Add(user);
                }
                
            }

            if (userByName.Count > 0)
            {
                return userByName;
            }

            Console.WriteLine("No user found!");
            return null;
        }

        //dodaje novog korisnika
        public static User AddNewUser(User user) {
            listOfUsers.Add(user);
            return user;
        }

        //brisanje korisnika na osnovu id
        public static void RemoveUser(int id){
            User removeUser = GetUserById(id);
            listOfUsers.Remove(removeUser);
        }

        public static User CreateNewUser(int id, string name, string email, string adresa, string zipCode, string cityName, string countryName, string phone)
        {
            User user = new User();
            user.Id = id;
            user.Name = name;
            user.Email = email;
            user.Adresa = adresa;
            user.ZipCode = zipCode;
            user.CityName = cityName;
            user.CountryName = countryName;
            user.Phone = phone;

            return user;
        }

        //modifikovanje korisnika
        public static User ModifyUser(int id, string name, string email, string adresa, string zipCode, string cityName, string countryName, string phone)
        {
            User user = CreateNewUser(id, name, email, adresa, zipCode, cityName, countryName, phone);
            RemoveUser(id);
            AddNewUser(user);

            return user;
    }
    }
}