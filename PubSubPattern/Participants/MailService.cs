using System;

namespace PubSubPattern.Participants
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine($"Sending {args.Video.Title} video via mail.......");
        }
    }
}