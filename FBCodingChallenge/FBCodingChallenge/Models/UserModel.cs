using FBDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBCodingChallenge.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public User getEntity()
        {
            User userEntity = new User();
            userEntity.UserName = this.UserName;
            userEntity.EmailAddress = this.EmailAddress;
            userEntity.Password = this.Password;
            return userEntity;
        }
    }
}