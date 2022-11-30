using test.Domain.Enum;

namespace test.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public TypeStatusAccount StatusAccount { get; set; }

    }
}
