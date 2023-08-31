using System;
using Xunit;
using FluentAssertions;

namespace CSharpCore.Test
{
    public class SystemTest
    {
        [Fact]
        public void NewlyCreatedSystem_hasNoLoggedInUsers()
        {
        }

        [Fact]
        public void OneUserIsLoggedIn_afterSuccessfulAuthorization()
        {
        }

        [Fact]
        public void ErrorMailIsSent_forInvalidUserName()
        {
        }

        [Fact]
        public void ErrorMailIsSent_onFailedLoginAttempt()
        {
        }

        [Fact]
        public void KnownUser_canLogin()
        {
        }
    }
}