namespace ClientRegistration.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public virtual Address Address { get; set; }

    }
}