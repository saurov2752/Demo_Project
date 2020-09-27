using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class PostStatus
    {
        public int PostID { get; set; }
        public string PostDetail { get; set; }
        public int PostUserID { get; set; }
        public DateTime PostDate { get; set; }
        public int CommentID { get; set; }
        public string CommentDetails { get; set; }
        public int CommentUserID { get; set; }
        public DateTime CommentDate { get; set; }
        public int LikeNo { get; set; }
        public int DislikeNo { get; set; }
        public int CommentNo { get; set; }
        public string PostUserName { get; set; }
        public string CommentUserName { get; set; }

        public string PostDateInSt
        {
            get
            {
                if (this.PostDate == DateTime.MinValue)
                    return "";
                return this.PostDate.ToString("dd MMM yyyy");
            }
        }
        public string CommentDateInSt
        {
            get
            {
                if (this.CommentDate == DateTime.MinValue)
                    return "";
                return this.CommentDate.ToString("dd MMM yyyy");
            }
        }
    }
}