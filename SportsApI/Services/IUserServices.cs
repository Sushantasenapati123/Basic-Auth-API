namespace SportsApI.Services
{
    public interface IUserServices
    {
        bool ValidateCredentials(string username, string password);
    }
}
