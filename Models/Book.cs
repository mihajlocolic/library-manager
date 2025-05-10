namespace LibraryManager.Models
{
    public class Book
    {

        public enum BookStatus
        {
            Available,
            Borrowed
        }

        public long Id {  get; set; }
        public string Title {  get; set; }
        public string Author {  get; set; }
        public string Genre {  get; set; }
        public BookStatus Status {  get; set; }
        public Member? Borrower {  get; set; }

        public Book() { }

        public Book(long id, string title, string author, string genre, BookStatus status, Member borrower)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Status = status;
            this.Borrower = borrower;
        }
    }
}
