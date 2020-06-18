using System;
namespace PubSubPattern.Participants
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void EncodeVideo(Video video)
        {
            System.Console.WriteLine("Encoding video");
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded!=null)
            VideoEncoded(this,new VideoEventArgs(){Video=video});
        }
    }
}