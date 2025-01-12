namespace Business.Models
{
    public class ContactFormat
    {

        public int Id { get; set; }
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;
    }

    public class ContactEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int Phone { get; set; }
    }
}
