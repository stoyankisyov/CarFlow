namespace CarFlow.Core.Models
{
    public class Account(
        int id,
        List<Role> roles,
        string name,
        string email,
        string phone,
        string password,
        string? address)
    {
        public int Id { get; } = id;
        public List<Role> Roles { get; } = roles;
        public string Name { get; } = name;
        public string Email { get; } = email;
        public string Phone { get; } = phone;
        public string Password { get; set; } = password;
        public string? Address { get; } = address;
    }
}
