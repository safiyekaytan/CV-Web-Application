using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class experiences
    {
        private int id;
        private String position;
        private String department;
        private String companyName;
        private DateTime startDate;
        private DateTime endDate;
        private String description;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public experiences(String position, String department, String companyName, DateTime startDate, DateTime endDate, String description, int userId, DateTime lastUpdatedDate, String lastUpdatedBy, DateTime creationDate, String createdBy)
        {

            this.Position = position;
            this.Department = department;
            this.CompanyName = companyName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Description = description;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Description { get => description; set => description = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}