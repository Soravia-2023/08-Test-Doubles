using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore.Test
{
    public class AuthorizerFake : IAuthorizer
    {
    public bool Authorize(string username, string password)
    {
        if (username.Equals("jimmy"))
        {
            return true;
        }
        return false;
    }
}
}
