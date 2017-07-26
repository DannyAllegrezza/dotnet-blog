using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dannyallegrezza.DAL.Models
{
    public class Author 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }

        private string _fullName;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set { _fullName = value; }
        }

    }
}
