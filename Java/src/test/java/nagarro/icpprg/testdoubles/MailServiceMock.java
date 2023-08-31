package nagarro.icpprg.testdoubles;

import org.assertj.core.api.Assertions;


public class MailServiceMock implements MailService {
    private int expectedErrorType;
    private int actualErrorType;

    @Override
    public void sendLoginFailureMail(String userName) {

    }

    @Override
    public void sendSystemFailureMail(int errorType) {
        actualErrorType = errorType;
    }

    public void expectFailureMail(int errorType) {

        this.expectedErrorType = errorType;
    }

    public void verify() {

        Assertions.assertThat(actualErrorType).isEqualTo(expectedErrorType);
    }

}
