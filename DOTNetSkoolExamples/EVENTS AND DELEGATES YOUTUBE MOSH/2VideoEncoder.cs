using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH
{

    #region VideoEncoder that passes an Argument
    //PUBLISHER PUBLISHER PUBLISHER//

    class VideoEncoder
    {   // To give this class(videoencoder) an ability to publish an event there are three steps involved:
        // 1 define a delegate-agreement between a publisher and a subscriber
        //2 Define an event based on that delegate
        //3 Raise the event



        //in autocad my custom command
        // a 3d polyline may be a publisher and a solid may be a subscriber
        // of a civil 3d assembly may be a publisher and circles associated with that assembly might be a subscriber
        //then later down the line the circles will be the publisher and 3d sweep associated will be subscribers


        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;//instance of the delegate
        

        public event EventHandler<VideoEventArgs> VideoEncoded;// above 2 lines in a single line


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);
            OnVideoEncode(video);
        }

        protected virtual void OnVideoEncode(Video video)
        {
            if (VideoEncoded != null)// if the event is not null then do something
            {       
                VideoEventArgs vEventArgs = new VideoEventArgs();
                vEventArgs.video1 = video;                
                VideoEncoded(this,vEventArgs);
            }
        }
    }

    public class VideoEventArgs:EventArgs
    {
        public Video video1 { get; set; }
    }
    #endregion

    #region Video Encoder that does not return any argument
    //class VideoEncoder
    //{   // To give this class(videoencoder) an ability to publish an event there are three steps involved:
    //    // 1 define a delegate-agreement between a publisher and a subscriber
    //    //2 Define an event based on that delegate
    //    //3 Raise the event



    //    //in autocad my custom command
    //    // a 3d polyline may be a publisher and a solid may be a subscriber
    //    // of a civil 3d assembly may be a publisher and circles associated with that assembly might be a subscriber
    //    //then later down the line the circles will be the publisher and 3d sweep associated will be subscribers


    //    public delegate void VideoEncodedEventHandler(object source, EventArgs args);
    //    public event VideoEncodedEventHandler VideoEncoded;//instance of the delegate

    //    public void Encode(Video video)
    //    {
    //        Console.WriteLine("Encoding video");
    //        Thread.Sleep(3000);
    //        OnVideoEncode();
    //    }

    //    protected virtual void OnVideoEncode()
    //    {
    //        if (VideoEncoded != null)
    //            VideoEncoded(this, EventArgs.Empty);
    //    }
    //}

    #endregion
}
