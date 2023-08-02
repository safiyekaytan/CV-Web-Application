using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class education
    {
        private int id;
        private String nameOfSchool;
        private String departmentForUniversity;
        private DateTime graduationDate;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public education(string nameOfSchool, string departmentForUniversity, DateTime graduationDate, int userId, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.NameOfSchool = nameOfSchool;
            this.DepartmentForUniversity = departmentForUniversity;
            this.GraduationDate = graduationDate;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }


        public string NameOfSchool { get => nameOfSchool; set => nameOfSchool = value; }
        public string DepartmentForUniversity { get => departmentForUniversity; set => departmentForUniversity = value; }
        public DateTime GraduationDate { get => graduationDate; set => graduationDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}