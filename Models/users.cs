using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class users
    {
        private int id;
        private String name;
        private String lastName;
        private String email;
        private int phone;
        private String aboutMe;
        private String userName;
        private String password;

        private String country;
        private String adress;
        private String company;
        private String job;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;
        public users(int id, string name, string lastName, string email, int phone, string aboutMe, string userName, string password, string country, string adress, string company, string job, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.AboutMe = aboutMe;
            this.UserName = userName;
            this.Password = password;
            this.Country = country;
            this.Adress = adress;
            this.Company = company;
            this.Job = job;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public string AboutMe { get => aboutMe; set => aboutMe = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public string Country { get => country; set => country = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Company { get => company; set => company = value; }
        public string Job { get => job; set => job = value; }
    }
}