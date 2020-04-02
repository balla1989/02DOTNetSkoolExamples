using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH;

namespace DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH
{
    public class MailServie
    {

        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine("Mail sent from Australian post....");
            Console.WriteLine(eventArgs.video1.Title);
        }
    }
}
