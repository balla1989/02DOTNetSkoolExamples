using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH;


namespace DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH
{
    class EmailService
    {
        public void OnVideoEncoded(object obj, VideoEventArgs eventArgs)
        {
            Console.WriteLine("Sending out emails....");
            Console.WriteLine(eventArgs.video1.Title);
        }
    }
}
