using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
   
    public class BlogPost
    {
        public string Title { get; private set; }

        public BlogPost(string title)
        {
            Title = title;
        }
    }
}
