import { IMailService } from "@/IMailService";

export default class mailServiceSpy implements IMailService {
  private _failedLoginUserName!: string;

  get failedLoginUserName() {
    return this._failedLoginUserName;
  }

  set failedLoginUserName(value: string) {
    this._failedLoginUserName = value;
  }

  sendLoginFailureMail(userName: string): void {
    this.failedLoginUserName = userName;
  }
  sendSystemFailureMail(errorType: number): void {}
}
