using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public virtual List<NoteList> Lists { get; set; }

        public User()
        {
            Lists = new List<NoteList>();
        }
    }
}
