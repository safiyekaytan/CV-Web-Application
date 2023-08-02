using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class certificates
    {
        private int id;
        private String name;
        private DateTime deliveryDate;
        private String instiution;
        private String departmanet;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public certificates(string name, DateTime deliveryDate, string instiution, string departmanet, int userId, DateTime lastUpdatedDate, string lastUpdatedBy, DateTime creationDate, string createdBy)
        {
            this.Name = name;
            this.DeliveryDate = deliveryDate;
            this.Instiution = instiution;
            this.Departmanet = departmanet;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public string Name { get => name; set => name = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public string Instiution { get => instiution; set => instiution = value; }
        public string Departmanet { get => departmanet; set => departmanet = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}