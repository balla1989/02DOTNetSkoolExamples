//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic;
//using System.Threading;
//using DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH;

//namespace DOTNetSkoolExamples
//{


//    public delegate void CallBack(int i);

//    public class Program
//    {

//        static void Main()////FRONT END
//        {

//            Video video = new Video() { Title = "Suman's Video" };
//            VideoEncoder videoEncoder = new VideoEncoder(); //publisher
//            videoEncoder.Encode(video);

//            MailServie mailService = new MailServie();//subscriber1
//            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;




//            EmailService emailService = new EmailService();//subscriber2
//            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;




//            Console.ReadLine();




//        }





//    }
//}
