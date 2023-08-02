using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class files
    {
        private int id;
        private String fileName;
        private String fileContentType;
        private String fileUrl;
        private String description;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public files(string fileName, string fileContentType, string fileUrl, string description, int userId, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.FileName = fileName;
            this.FileContentType = fileContentType;
            this.FileUrl = fileUrl;
            this.Description = description;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public string FileName { get => fileName; set => fileName = value; }
        public string FileContentType { get => fileContentType; set => fileContentType = value; }
        public string FileUrl { get => fileUrl; set => fileUrl = value; }
        public string Description { get => description; set => description = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}