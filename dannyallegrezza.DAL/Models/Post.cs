using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
        public Category Category { get; set; }
        #endregion Properties

        #region IContent Members
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Provides a santized version of the Category Title
        /// </summary>
        /// <returns>Formatted version of the Category Title. </returns>
        public string SanitizedUrl()
        {
            if (Title == null) { return null; }

            var key = Regex.Replace(Title, @"[^a-zA-Z0-9\- ]", string.Empty);
            return key.Replace(" ", "-").ToLower();
        }
        #endregion IContent Members

        public Post()
        {

        }
    }
}
