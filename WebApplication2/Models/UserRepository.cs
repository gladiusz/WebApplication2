using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserRepository
    {
        static List<UserModel> Userzy = new List<UserModel>();

        public List<UserModel> GetList()
        {
            return Userzy;
        }

        public UserModel Get(string login, string password)
        {
            return Userzy.SingleOrDefault(a => a.Login == login && a.Password == password);
        }
  
        public void Add(UserModel user)
        {
            user.Id = Guid.NewGuid();
            Userzy.Add(user);
        }
    }
}