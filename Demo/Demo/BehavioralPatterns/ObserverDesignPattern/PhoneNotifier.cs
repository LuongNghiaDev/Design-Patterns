using Demo.BehavioralPatterns.ObserverDesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.ObserverDesignPattern
{
    class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via EMAIL with new data" +
                                      "\n\tName: {0}" +
                                      "\n\tDescription: {1}" +
                                      "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
