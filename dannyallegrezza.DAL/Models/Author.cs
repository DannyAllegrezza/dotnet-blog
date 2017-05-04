using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dannyallegrezza.DAL.Models
{
    public class Author : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _fullName;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set { _fullName = value; }
        }

    }
}
