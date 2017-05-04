namespace dannyallegrezza.DAL.Models
{
    /// <summary>
    /// Represents a pure join table between the Post table and the Tag table
    /// </summary>
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
