using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Inheritance
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            this.ID = 0;
            this.Title = "My First Post";
            this.IsPublic = true;
            this.SendByUserName = "Dekel";
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendByUserName}");
        }
    }
}
