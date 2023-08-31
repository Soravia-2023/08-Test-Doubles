package nagarro.icpprg.testdoubles;

public interface Authorizer {
    boolean authorize(String username, String password);
}