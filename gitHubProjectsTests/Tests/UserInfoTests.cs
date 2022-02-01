using Xunit;
using gitHubProjectsAPI.Business;

namespace gitHubProjectsTests.Tests
{
    public class UserInfoTests
    {
        [Fact]
        public void Fact_GetUserLogin ()
        {
            var UserInfoBusiness = new UserInfoBusiness();
            var user = UserInfoBusiness.GetUserInfo("bhryanh");
            
            Assert.Equal("bhryanh", user.Login);
        }        
    }
}