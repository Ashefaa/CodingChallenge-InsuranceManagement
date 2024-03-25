using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Entity
{
    public class Users
    {
        private int userId;
        private string userName;
        private string password;
        private string role;
        //Property for userName
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        // Property for Username
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        // Property for Password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Property for Role
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public Users()
        { }

        public Users(int userId,string userName,string password,string role)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        
        //Method to print 
        public void PrintDetails()
        {
            Console.WriteLine($"User ID: {UserId}");
            Console.WriteLine($"Username:  {UserName}");
            Console.WriteLine($"Password:   {Password}");
            Console.WriteLine($"Role:  {Role}");
        }
        

    }
}
