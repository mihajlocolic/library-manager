namespace LibraryManager.Models
{
    internal class Book
    {

        enum BookStatus
        {
            Borrowed,
            Available
        }

        private long id {  get; set; }
        private string title {  get; set; }
        private string author {  get; set; }
        private string genre {  get; set; }
        private BookStatus status {  get; set; }
        private int? borrowerId {  get; set; }
    }
}
