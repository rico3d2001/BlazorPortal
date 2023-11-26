namespace BlazorPortal.Auth
{
    public interface IAuthorizeService
    {
        Task Login(string token);
        Task Logout();
        Task<bool> Register(string username, string password);
    }
}
