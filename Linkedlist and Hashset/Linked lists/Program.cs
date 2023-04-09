using System;
using System.Collections.Generic;

namespace Linked_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var video1 = new YoutubeVideos(11, "first video",new TimeSpan(00, 30, 00));
            var video2 = new YoutubeVideos(22, "seconed cideo", new TimeSpan(00, 40, 03));
            var video3 = new YoutubeVideos(33, "third video", new TimeSpan(00, 30, 00));
            var video4= new YoutubeVideos(44, "fourth video", new TimeSpan(00, 40, 03));
            var video5 = new YoutubeVideos(55, "fifth video", new TimeSpan(00, 30, 00));
            var video6 = new YoutubeVideos(66, " sex video", new TimeSpan(00, 40, 03));

            LinkedList<YoutubeVideos> playList = new LinkedList<YoutubeVideos>
               ( new YoutubeVideos[] { video1, video2, video3, video4, video5, video6 });



          print("master c#", playList);
            void print(string title,LinkedList<YoutubeVideos> ls )
            {
                Console.WriteLine(title);
                foreach (var item in ls)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"└");
                Console.WriteLine($"total numbers: {ls.Count}");
            }
        
        }
    }
    class YoutubeVideos
    {
        public int id { set; get; }
        public string title { set; get;}
        public TimeSpan Duration { set; get;}

        public YoutubeVideos(int id, string title, TimeSpan duration)
        {
            this.id = id;
            this.title = title;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return $"{$"├── {title} ({Duration})\n│\thttps://www.youtube.com/watch?v={id}"}";
        }
    }
}
