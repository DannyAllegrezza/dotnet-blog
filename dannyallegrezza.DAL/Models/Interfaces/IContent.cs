using System;

namespace dannyallegrezza.DAL.Models
{
    /// <summary>
    /// Interface for a genetic piece of content. 
    /// EX: Blog post, a Tag, etc.
    /// </summary>
    public interface IContent
    {
        Author Author { get; set; }
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        string Title { get; set; }
        string SanitizedUrl(); 
    }
}
