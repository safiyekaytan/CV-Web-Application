using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class images
    {
        private int id;
        private String url;
        private String description;
        private int userId;
        private String typee;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public images(string url, string description, int userId, string typee, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.Url = url;
            this.Description = description;
            this.UserId = userId;
            this.Typee = typee;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public string Url { get => url; set => url = value; }
        public string Description { get => description; set => description = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Typee { get => typee; set => typee = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}