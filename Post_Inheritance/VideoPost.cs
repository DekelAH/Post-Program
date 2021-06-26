using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Post_Inheritance
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, bool isPublic, string videoURL, int length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            this.Length = length;
            this.VideoURL = videoURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length}:00 minutes - by {this.SendByUserName}");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }

        private void TimerCallBack(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
