using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class services
    {
        private int id;
        private String title;
        private String description;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public services(string title, string description, int userId, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.Title = title;
            this.Description = description;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}