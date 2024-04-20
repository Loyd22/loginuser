using System.Security;
using Accountdata;
using accountbusiness;
using usermodel;

namespace UserAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER USERNAME: ");
            string user = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD: ");
            string password = Console.ReadLine();

            userBusiness accountdata = new userBusiness();
            bool result = accountdata.Verifyusername(user, password);

            if (result)
            {
                Console.WriteLine(" welcome to website");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
