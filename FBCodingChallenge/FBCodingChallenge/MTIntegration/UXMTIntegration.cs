using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FBCommonCode;
using FBCodingChallenge.Models;
using FBDAL.Entity;

namespace FBCodingChallenge.MTIntegration
{
    public class UxMTIntegration: MTIntegrationBase
    {
        public UxMTIntegration():base()
        {
            
        }

        public void AddUser(UserModel user)
        {
            User userEntity = user.getEntity();
            userRepository.AddUser(userEntity);
        }
        public void GetUser(UserModel user)
        {
            User userEntity = user.getEntity();
            userRepository.GetUser(userEntity);
        }
       
    }
}