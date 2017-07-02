using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace test20170619
{
    public class TestService : System.Web.Services.WebService
    {

        public UserDetails user;

        [WebMethod]
        [SoapHeader("user")]
        public String SayHello(string name)
        {
            if (user != null)
            {
                if (user.IsValid())
                {
                    return "SUCCESS.";
                }
                else
                {
                    return "failed.";
                }
            }
            else
            {
                return "ERROR.";
            }
        }
    }
}
