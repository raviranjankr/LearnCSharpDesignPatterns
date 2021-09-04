using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
     // Blog Post seekers that need to be notified for a Blog posting
    public class BlogPostSeeker : IObserver<BlogPost>
    {
        public string Name { get; private set; }

        public BlogPostSeeker(string name)
        {
            Name = name;
        }
        public void OnCompleted()
        {            
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(BlogPost value)
        {
            Console.WriteLine($"Hi {Name}, A New Blog Posted: {value.Title}");
        }
    }
}
