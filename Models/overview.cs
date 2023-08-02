using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme.Tables
{
    public partial class overview
    { 
        private String fullName;
        private String aboutMe;
        private String company;
        private String country;
        private String job;
        private String adress;
        private String email;
        private int phone;
        private String imageUrl;

        public overview(string fullName, string aboutMe, string company, string country, string job, string adress, string email, int phone, string imageUrl)
        {
            this.FullName = fullName;
            this.AboutMe = aboutMe;
            this.Company = company;
            this.Country = country;
            this.Job = job;
            this.Adress = adress;
            this.Email = email;
            this.Phone = phone;
            this.ImageUrl = imageUrl;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string AboutMe { get => aboutMe; set => aboutMe = value; }
        public string Company { get => company; set => company = value; }
        public string Country { get => country; set => country = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Job { get => job; set => job = value; }
    }
}