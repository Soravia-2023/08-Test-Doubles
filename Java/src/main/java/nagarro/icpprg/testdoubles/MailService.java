package nagarro.icpprg.testdoubles;

public interface MailService {
    void sendLoginFailureMail(String userName);

    void sendSystemFailureMail(int errorType);
}
