package nagarro.icpprg.testdoubles;

public class MailServiceSpy implements MailService {
    public String failedLoginUserName;

    @Override
    public void sendLoginFailureMail(String userName) {
        failedLoginUserName = userName;
    }

    @Override
    public void sendSystemFailureMail(int errorType) {

    }
}
