namespace CSharpCore.Test
{
    public class MailServiceSpy : IMailService
    {
        private string failedLoginUserName;

        public string FailedLoginUserName { get => failedLoginUserName; set => failedLoginUserName = value; }

        public void SendLoginFailureMail(string userName)
        {
            FailedLoginUserName = userName;
        }

        public void SendSystemFailureMail(int errorType)
        {

        }
    }
}