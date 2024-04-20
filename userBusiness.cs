using Accountdata;
namespace accountbusiness
{
    public class userBusiness
    {
        public bool Verifyusername (string useracc,string password)
        {
            userdata dataservice = new userdata();
            var result = dataservice.GetAccount(useracc);

            return result.useracc != null ? true : false;
        }
    }
}
