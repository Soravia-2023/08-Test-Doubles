import System from "@/system";
import acceptingAuthorizerStub from "./acceptingAuthorizerStub";
import authorizerDummy from "./authorizerDummy";
import authorizerFake from "./authorizerFake";
import mailServiceMock from "./mailServiceMock";
import mailServiceSpy from "./mailServiceSpy";
import rejectingAuthorizerStub from "./rejectingAuthorizerStub";

describe("System test", () => {
  it("newlyCreatedSystem_hasNoLoggedInUsers", () => {
    const sut = new System(new authorizerDummy(), null);
    expect(sut.loginCount()).toBe(0);
  });

  it("oneUserIsLoggedIn_afterSuccessfulAuthorization", () => {
    const sut = new System(new acceptingAuthorizerStub(), null);
    sut.performLogin("username", "password");
    expect(sut.loginCount()).toBe(1);
  });

  it("errorMailIsSent_onFailedLoginAttempt", () => {
    const mailService = new mailServiceSpy();
    const sut = new System(new rejectingAuthorizerStub(), mailService);
    sut.performLogin("username", "password");
    expect(sut.loginCount()).toBe(0);
    expect(mailService.failedLoginUserName).toBe("username");
  });

  it("errorMailIsSent_forInvalidUserName", () => {
    const mailService = new mailServiceMock();
    mailService.expectFailureMail(System.errorInvalidUserName);
    const sut = new System(null, mailService);
    sut.performLogin("", "password");
    mailService.verify();
  });

  it("knownUser_canLogin", () => {
    const sut = new System(new authorizerFake(), null);
    expect(sut.loginCount()).toBe(0);
    sut.performLogin("jimmy", "password");
    expect(sut.loginCount()).toBe(1);
  });
});
