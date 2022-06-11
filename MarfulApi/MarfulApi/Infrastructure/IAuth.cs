namespace MarfulApi.Infrastructure
{
    public interface IAuth
    {
        object? GetAuth(string email, string password);
    }
}
