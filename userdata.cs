using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using usermodel;
namespace Accountdata
{
    public class userdata
    {
        List<username> user = new List<username>();

        public userdata()
        {
            createdummyaccount();
        }
        private void createdummyaccount()
        {
            username user1 = new username
            {
                useracc = "loyd",
                password = "1234"
            };
            username user2 = new username
            {
                useracc = "john",
                password = "123"
            };
            username user3 = new username
            {
                useracc = "viray",
                password = "12345"
            };

            user.Add(user1);
            user.Add(user2);
            user.Add(user3);
        }

        public username GetAccount (string useracc)
        {
            username foundAccount = new username();

            foreach (username user in user)
            {
                if (user.useracc == useracc)
                {
                    foundAccount=user;
                }
            }

            return foundAccount;

        }
    }
}
