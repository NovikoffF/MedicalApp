using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp
{
    class User
    {
        private readonly string id;
        public string Id { get; set; }
        protected string password;
        protected string roleName;
        public string Email { get; set; }
        public string NameUser { get; set; }
        public string Surname { get; set; }

        public User (string id, string pass, string rname, string email, string name, string surname )
        {
            Id = id;
            password = pass;
            roleName = rname;
            Email = email;
            NameUser = name;
            Surname = surname;
        }

        public void ForgottenPassword(string email)
        {

        }

        public void ChangePassword(string NewPassword)
        {
            

        }

    }
}
