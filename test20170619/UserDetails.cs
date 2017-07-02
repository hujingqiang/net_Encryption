using System;
namespace test20170619
{
    public class UserDetails:System.Web.Services.Protocols.SoapHeader
    {
        public String userName { get; set; }
        public String password { get; set; }


		public bool IsValid()
		{
			//Write the logic to Check the User Details From DataBase  
			//i can chek with some hardcode details UserName=Nitin and Password=Pandit  
			return this.userName == "hu" && this.password == "adam";
			//it'll check the details and will return true or false   
		}

    }
}
