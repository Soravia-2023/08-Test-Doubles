namespace CSharpCore.Test
{
    public class RejectingAuthorizerStub : IAuthorizer
    {
    public bool Authorize(string username, string password)
    {
        return false;
    }
}
}