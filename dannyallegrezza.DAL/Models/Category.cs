using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace dannyallegrezza.DAL.Models
{
    public class Category : IContent
    {
        #region Properties
        /// <summary>
        /// Returns the properly formatted version of the item 
        /// </summary>
        [NotMapped]
        public string Key
        {
            get
            {
                if (Title == null)
                    return null;

                var key = Regex.Replace(Title, @"[^a-zA-Z0-9\- ]", string.Empty);
                return key.Replace(" ", "-").ToLower();
            }
        }
        #endregion Properties

        #region #region IContent Members
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
    }
}
