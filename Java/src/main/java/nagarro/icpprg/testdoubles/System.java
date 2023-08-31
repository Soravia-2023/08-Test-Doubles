package nagarro.icpprg.testdoubles;

public class System {
    public static final int ERROR_INVALID_USER_NAME = 0;
    private final Authorizer authorizer;
    private MailService mailService;
    private int loginCount = 0;

    public System(Authorizer authorizer, MailService mailService) {
        this.authorizer = authorizer;
        this.mailService = mailService;
    }

    public int loginCount() {
        return loginCount;
    }

    public void performLogin(String userName, String password) {
        if (userName.isEmpty()) {
            mailService.sendSystemFailureMail(System.ERROR_INVALID_USER_NAME);
            return;
        }

        if (!authorizer.authorize(userName, password)) {
            mailService.sendLoginFailureMail(userName);
            return;
        }

        loginCount++;
    }
}