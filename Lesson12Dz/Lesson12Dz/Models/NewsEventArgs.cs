using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Dz.Models
{
    delegate void MyEventHandler(object source, NewsEventArgs arg);
    class NewsEventArgs : EventArgs
    {
        public string Category { get; }
        public string News { get; }

        public NewsEventArgs(string category, string news)
        {
            Category = category;
            News = news;
        }
    }
}
