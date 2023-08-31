namespace CSharpCore.Test
{
    public class AcceptingAuthorizerStub : IAuthorizer
    {
        public bool Authorize(string username, string password)
        {
            return true;
        }
    }
}