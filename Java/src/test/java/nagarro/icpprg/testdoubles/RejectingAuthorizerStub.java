package nagarro.icpprg.testdoubles;

public class RejectingAuthorizerStub implements Authorizer {
    public boolean authorize(String username, String password) {
        return false;
    }
}