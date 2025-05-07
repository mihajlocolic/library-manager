namespace LibraryManager.Models
{
    public class Book
    {

        public enum BookStatus
        {
            Available,
            Borrowed
        }

        public long id {  get; set; }
        public string title {  get; set; }
        public string author {  get; set; }
        public string genre {  get; set; }
        public BookStatus Status {  get; set; }
        public int? borrowerId {  get; set; }

        public Book() { }

        public Book(long id, string title, string author, string genre)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
        }
    }
}
