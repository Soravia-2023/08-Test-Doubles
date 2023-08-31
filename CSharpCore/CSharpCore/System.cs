using System;

namespace CSharpCore
{
    public class System
    {
        public static readonly int ErrorInvalidUserName = 5;
        private readonly IAuthorizer authorizer;
        private IMailService mailService;
        private int loginCount = 0;

        public System(IAuthorizer authorizer, IMailService mailService)
        {
            this.authorizer = authorizer;
            this.mailService = mailService;
        }

        public int LoginCount()
        {
            return loginCount;
        }

        public void PerformLogin(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName))
            {
                mailService.SendSystemFailureMail(System.ErrorInvalidUserName);
                return;
            }

            if (!authorizer.Authorize(userName, password))
            {
                mailService.SendLoginFailureMail(userName);
                return;
            }

            loginCount++;
        }
    }
}
