using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class NoteList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual List<Note> Notes { get; set; }

        public NoteList()
        {
            Notes = new List<Note>();
        }
    }
}
