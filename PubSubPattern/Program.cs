using System;
using PubSubPattern.Participants;

namespace PubSubPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder videoEncoder=new VideoEncoder();
            var mailService=new MailService();
            var whatsAppService=new WhatsAppService();
            videoEncoder.VideoEncoded+=mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded+=whatsAppService.OnVideoEncoded;

            videoEncoder.EncodeVideo(new Video{Title="'The Lallantop Show'"});
            videoEncoder.EncodeVideo(new Video{Title="'Duniadaari'"});
        }
    }
}
