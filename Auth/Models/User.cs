namespace Auth.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Information { get; set; } = string.Empty;
    }

    public static class UserConstants
    {
        public static List<User> Users = new()
        {
            new User(){
                Id = 1,
                Username = "string",
                Password = "string",
                Information = "User information"
            },
            new User(){
                Id = 2,
                Username = "string2",
                Password = "string",
                Information = "User information 2"
            }
        };
    }

}
