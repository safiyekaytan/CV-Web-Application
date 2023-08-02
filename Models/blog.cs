using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspxliDeneme
{
    public partial class blog
    {
        private int id;
        private int imagesId;
        private string title;
        private String content;
        private DateTime publishDate;
        private int userId;
        private DateTime lastUpdatedDate;
        private String lastUpdatedBy;
        private DateTime creationDate;
        private String createdBy;

        public blog(int imagesId, string title, string content, 
            DateTime publishDate, int userId, 
            DateTime lastUpdatedDate, string lastUpdatedBy,
            DateTime creationDate, string createdBy)
        {
            this.ImagesId = imagesId;
            this.Title = title;
            this.Content = content;
            this.PublishDate = publishDate;
            this.UserId = userId;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreationDate = creationDate;
            this.CreatedBy = createdBy;
        }

        public int ImagesId { get => imagesId; set => imagesId = value; }
        public string Content { get => content; set => content = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime LastUpdatedDate { get => lastUpdatedDate; set => lastUpdatedDate = value; }
        public string LastUpdatedBy { get => lastUpdatedBy; set => lastUpdatedBy = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public string Title { get => title; set => title = value; }
    }
}