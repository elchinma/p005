using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p005
{
    internal class User
    {
        public string Username;
        public string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public void ShowUserandPass()
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}");
        }
    
        static void Main(string[] args)
        {
            
        }
    }
}
