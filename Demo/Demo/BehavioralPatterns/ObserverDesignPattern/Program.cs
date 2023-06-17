using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            _ = new EmailNotifier(videoData);
            _ = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");

            videoData.DetachObserver(youtubeNotifier);
            videoData.SetDescription("Video");

            Console.ReadKey();
        }
    }
}
