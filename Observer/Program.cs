using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Subscribers
            BlogPostSeeker blogPostSeeker_1 = new BlogPostSeeker("Subscriber A");
            BlogPostSeeker blogPostSeeker_2 = new BlogPostSeeker("Subscriber B");

            //Create publisher and attch subscribers
            BlogPosting blogPostings = new BlogPosting();
            blogPostings.Subscribe(blogPostSeeker_1);
            blogPostings.Subscribe(blogPostSeeker_2);

            //Add a new Blog and see if subscribers get notified
            blogPostings.AddBlog(new BlogPost("Learn about Observer Design Pattern"));            
            Console.ReadLine();
        }
    }
}
