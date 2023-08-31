package nagarro.icpprg.testdoubles;

public class AuthorizerFake implements Authorizer {
    @Override
    public boolean authorize(String username, String password) {
        if (username.equals("jimmy")) {
            return true;
        }
        return false;
    }
}
