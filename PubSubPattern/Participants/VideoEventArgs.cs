using System;
namespace PubSubPattern.Participants
{
    public class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }
    }
}