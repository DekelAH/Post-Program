using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Dekel A");
            Console.WriteLine(post1.ToString());

            ImagePost newImagePost1 = new ImagePost("Check out my new shoes", "Dekel A", "https://images.com/shoes", true);
            Console.WriteLine(newImagePost1.ToString());

            VideoPost newVideoPost = new VideoPost("Check out my new Car", "Dekel A", true, "https://videos.com/cars", 10);
            Console.WriteLine(newVideoPost.ToString());

            newVideoPost.Play();
            Console.WriteLine("Press any key to stop the video.");
            Console.ReadKey();
            newVideoPost.Stop();

            Console.ReadLine();
        }
    }
}
