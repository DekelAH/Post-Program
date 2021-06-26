using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Inheritance
{
    class ImagePost : Post
    {
        protected string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.ID = GetNextId(); // getting from parent
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUserName}");
        }
    }
}
