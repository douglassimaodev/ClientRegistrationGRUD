namespace ClientRegistration.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public virtual Client Client { get; set; }
    }
}
