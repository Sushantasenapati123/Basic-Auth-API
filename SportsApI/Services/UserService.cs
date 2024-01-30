namespace SportsApI.Services
{
    public class UserService:IUserServices
    {
        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }
    }
}
