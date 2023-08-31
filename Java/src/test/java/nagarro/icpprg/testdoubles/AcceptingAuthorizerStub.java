package nagarro.icpprg.testdoubles;

public class AcceptingAuthorizerStub implements Authorizer {
    public boolean authorize(String username, String password) {
        return true;
    }

}