using System;

namespace CSharpCore.Test
{

    public class AuthorizerDummy : IAuthorizer
    {
        public bool Authorize(String username, String password)
        {
            return false;
        }
    }
}
