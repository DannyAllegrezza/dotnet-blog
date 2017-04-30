using System;
using System.Collections.Generic;
using System.Text;

namespace dannyallegrezza.DAL.Models
{
    /// <summary>
    /// A blog post object
    /// </summary>
    public class Post : IContent
    {
        #region Properties
        public string Content { get; set; }
        public string Excerpt { get; set; }
        #endregion Properties

        #region IContent Members
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Id { get; set; }
        #endregion IContent Members

        public Post()
        {

        }
    }
}
