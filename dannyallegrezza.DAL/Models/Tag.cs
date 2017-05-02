using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace dannyallegrezza.DAL.Models
{
    /// <summary>
    /// A class to represent a Tag object, which is used to associate pieces of content with a keyword.
    /// </summary>
    public class Tag : IContent
    {
        #region IContent Members
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Provides a santized version of the Tag Title
        /// </summary>
        /// <returns>Formatted version of the Tag Title. </returns>
        public string SanitizedUrl()
        {
            if (Title == null) { return null; }

            var key = Regex.Replace(Title, @"[^a-zA-Z0-9\- ]", string.Empty);
            return key.Replace(" ", "-").ToLower();
        }
        #endregion IContent Members
    }
}
