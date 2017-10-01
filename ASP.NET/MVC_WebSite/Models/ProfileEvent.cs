using MVC_WebSite.Models.EDM;
using System.Collections.Generic;
using System.Linq;

namespace MVC_WebSite.Models
{
    public class ProfileEvent
    {
        static BDD access = new BDD();
        static AuthData ad = new AuthData();

        // Verify if user exist
        public static User UserConnect(string login, string password)
        {
                var person = from p in access.User
                 
                         where p.login == login
                         where p.password == password
                         select p;
            if (person.Count() == 0)
            {
                return null;
            }

            return person.SingleOrDefault();
        }

        // Sign up : Add a new user 
        public static User addUser(string login,string mail)
        {
      
            var adduser = (from user in access.User
                          where user.login == login
                          where user.email == mail
                          select user).SingleOrDefault();
            return adduser;
        }

        //display user information
        public static User DisplayUser(string session)
        {
            return (from p in access.User
                    where p.login == session
                    select p).Single();
        }

        // Suppress User account 
        public static User SuppressAcount(string login)
        {
            return (from u in access.User
                    where u.login == login
                    select u).SingleOrDefault();
        }

        // List all Users 
        public static List<User> DisplayAllUsers()
        {
            return (from u in access.User
                    select u).ToList();
        }
  
    }
}