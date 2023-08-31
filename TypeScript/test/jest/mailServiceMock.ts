import { IMailService } from "@/IMailService";

export default class mailServiceMock implements IMailService {
  private expectedErrorType!: number;
  private actualErrorType!: number;

  sendLoginFailureMail(userName: string): void {}

  sendSystemFailureMail(errorType: number): void {
    this.expectedErrorType = errorType;
  }

  expectFailureMail(errorType: number): void {
    this.expectedErrorType = errorType;
  }

  public verify(): void {
    expect(this.actualErrorType).toBe(this.expectedErrorType);
  }
}
