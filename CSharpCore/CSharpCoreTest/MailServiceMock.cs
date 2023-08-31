using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace CSharpCore.Test
{
    public partial class MailServiceMock : IMailService
    {
        private int expectedErrorType;
        private int actualErrorType;

        public void SendLoginFailureMail(String userName)
        {

        }


        public void SendSystemFailureMail(int errorType)
        {
            actualErrorType = errorType;
        }

        public void ExpectFailureMail(int errorType)
        {
            this.expectedErrorType = errorType;
        }

        public void Verify()
        {
            actualErrorType.Should().Be(expectedErrorType);
        }
    }
}
