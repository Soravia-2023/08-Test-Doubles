namespace CSharpCore
{
    public interface IMailService
    {
        void SendLoginFailureMail(string userName);

        void SendSystemFailureMail(int errorType);
    }
}