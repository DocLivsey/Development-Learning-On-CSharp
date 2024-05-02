using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class User
    {
        private string Name { set; get; }
        private string Address { set; get; }
        private string Gender { set; get; }
        private string OtherInfo { set; get; }
        public User(string name, string address, string gender, string otherInfo)
        {
            this.Name = name;
            this.Address = address;
            this.Gender = gender;
            this.OtherInfo = otherInfo;
        }
        override 
        public string ToString()
        {
            return "Name: " + this.Name + "\nAddress: " + this.Address + "\nGender: " 
                   + this.Gender + "\nOther Info: " + this.OtherInfo;
        }
    }

    public class UsersList
    {
        private List<User> Users { set; get; }
        public UsersList(List<User> users)
        { this.Users = users; }
        public UsersList()
        { this.Users = new List<User>(); }
        public void AppendNewUser(User user)
        { this.Users.Add(user); }
        public override string ToString()
        {
            var users = "";
            foreach (var user in this.Users)
                users += user + "\n";
            return users;
        }
    }
}