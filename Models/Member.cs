namespace LibraryManager.Models
{
    public class Member
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber {  get; set; }

        public Member() { }
        public Member(long id, string firstName, string lastName, string phoneNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }
    }
}
