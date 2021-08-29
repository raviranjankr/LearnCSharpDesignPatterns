using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    // Blog Posting to which the blog seekers will subscribe
    public class BlogPosting : IObservable<BlogPost>
    {
        private List<IObserver<BlogPost>> mObservers;
        private List<BlogPost> mBlogPostings;

        public BlogPosting()
        {
            mObservers = new List<IObserver<BlogPost>>();
            mBlogPostings = new List<BlogPost>();
        }
        public IDisposable Subscribe(IObserver<BlogPost> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!mObservers.Contains(observer))
            {
                mObservers.Add(observer);
            }
            return new Unsubscriber<BlogPost>(mObservers, observer);
        }

        private void Notify(BlogPost blogPost)
        {
            foreach (var observer in mObservers)
            {
                observer.OnNext(blogPost);
            }
        }
        // Adding new blog, that will get notified to subscriber
        public void AddBlog(BlogPost blogPost)
        {
            mBlogPostings.Add(blogPost);
            Notify(blogPost);
        }

    }

    // Blog Posting to which the blog seekers will unsubscribe
    internal class Unsubscriber<BlogPost> : IDisposable
    {
        private List<IObserver<BlogPost>> mObservers;
        private IObserver<BlogPost> mObserver;

        internal Unsubscriber(List<IObserver<BlogPost>> observers, IObserver<BlogPost> observer)
        {
            this.mObservers = observers;
            this.mObserver = observer;
        }

        public void Dispose()
        {
            if (mObservers.Contains(mObserver))
                mObservers.Remove(mObserver);
        }
    }
}
