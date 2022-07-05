namespace AuthProvider
{
    public class UserApiModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserRole RoleType {get; set; }

    }
    public enum UserRole
    {
        Admin = 1,
        Viewer = 2,
        Salesman
    }
}
