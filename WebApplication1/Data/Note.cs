namespace WebApplication1.Data
{
    public class Note
    {
        public int Id { get; set; }
        public string AssigneeId { get; set; }
        public virtual User? Assignee { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int NoteListId { get; set; }
        public virtual NoteList? NoteList { get; set; }
    }
}
