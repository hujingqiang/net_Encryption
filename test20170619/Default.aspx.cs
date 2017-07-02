using System;
using System.Web;
using System.Web.UI;
//using n127_0_0_1;

namespace test20170619
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
           
            www.keepbalance.net.ws ws = new www.keepbalance.net.ws();
            n127_0_0_1.TestService ts = new n127_0_0_1.TestService();

            n127_0_0_1.UserDetails user = new n127_0_0_1.UserDetails();
			user.userName = "hu";
			user.password = "adam";
            ts.UserDetailsValue = user;

            //ts.SayHello("");
            //ws.AD_customerLoginFromHP()
            //www.keepbalance.net.
            //testmgr.TestService ts = new TestService();
            //ts.Admin = user;
            button1.Text = ts.SayHello("");
        }
    }
}
