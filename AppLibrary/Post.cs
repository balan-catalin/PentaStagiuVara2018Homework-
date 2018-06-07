using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class Post
    {
        private String Message;
        private Account Author;
        private DateTime timePost;

        public Post(String Message,Account Author, DateTime timePost)
        {
            this.Message = Message;
            this.Author = Author;
            this.timePost = timePost;
        }


        public override string ToString()
        {
            return Message + "\n\t" + Author.getUser().ToString() + " at " + timePost.ToLongTimeString().ToString();
        }
    }
}
