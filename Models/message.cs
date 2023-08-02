using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme.Tables
{
    public class message
    {
        private int id;
        private String name;
        private String email;
        private String subject;
        private String messageAtt;
        private int userId;

        public message(string name, string email, string subject, string messageAtt, int userId)
        {
            this.Name = name;
            this.Email = email;
            this.Subject = subject;
            this.MessageAtt = messageAtt;
            this.UserId = userId;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public string MessageAtt { get => messageAtt; set => messageAtt = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}