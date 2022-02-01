using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitHubProjectsAPI.Business.Interface;
using gitHubProjectsAPI.Model;

namespace gitHubProjectsAPI.Business
{
    public class UserInfoBusiness : IUserInfoBusiness
    {
        public User GetUserInfo(string login)
        {
            User user = new User();
            user.Login = "bhryanh";
            return user;
        }
    }
}