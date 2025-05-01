namespace LibraryManager.Models
{
    internal class Member
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName {  get; set; }
        public string phoneNumber {  get; set; }

        public Member() { }
        public Member(long id, string firstName, string lastName, string phoneNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }
    }
}
