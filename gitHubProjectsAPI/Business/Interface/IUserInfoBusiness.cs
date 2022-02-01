using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitHubProjectsAPI.Model;

namespace gitHubProjectsAPI.Business.Interface
{
    public interface IUserInfoBusiness
    {
        User GetUserInfo(string login);        
    }
}