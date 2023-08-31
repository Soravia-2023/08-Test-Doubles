namespace CSharpCore
{
    public interface IAuthorizer
    {
        bool Authorize(string username, string password);
    }
}