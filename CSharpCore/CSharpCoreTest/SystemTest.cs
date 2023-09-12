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
            System sut = new System(new AuthorizerDummy(), null);

            sut.LoginCount().Should().Be(0);
        }

        [Fact]
        public void OneUserIsLoggedIn_afterSuccessfulAuthorization()
        {
            System sut = new System(new AcceptingAuthorizerStub(), null);
            //Act
            sut.PerformLogin("username", "password");

            sut.LoginCount().Should().Be(1);

        }

        [Fact]
        public void ErrorMailIsSent_forInvalidUserName()
        {
            MailServiceMock mock = new MailServiceMock();
            mock.ExpectFailureMail(System.ErrorInvalidUserName);
            System sut = new System(new RejectingAuthorizerStub(), mock);
            //Act
            sut.PerformLogin("", "password");
            mock.Verify();
        }

        [Fact]
        public void ErrorMailIsSent_onFailedLoginAttempt()
        {
            MailServiceSpy spy = new MailServiceSpy();
            System sut = new System(new RejectingAuthorizerStub(), spy);
            //Act
            sut.PerformLogin("username", "password");

            sut.LoginCount().Should().Be(0);
            spy.FailedLoginUserName.Should().Be("username");
        }

        [Fact]
        public void KnownUser_canLogin()
        {
            System sut = new System(new AuthorizerFake(), null);

            sut.PerformLogin("jimmy", "password");
            sut.LoginCount().Should().Be(1);
        }
    }
}