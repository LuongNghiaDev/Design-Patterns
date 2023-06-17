using Demo.BehavioralPatterns.ObserverDesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.ObserverDesignPattern
{
    public class VideoData: Subject 
    {
        private string _title;
        private string _description;
        private string _fileName;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string value)
        {
            _fileName = value;
            VideoDataChanged();
        }

        private void VideoDataChanged()
        {
            NotifyObservers(this);
        }
    }
}
