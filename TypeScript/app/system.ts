import { IAuthorizer } from "./IAuthorizer";
import { IMailService } from "./IMailService";

export default class System {
  public static readonly errorInvalidUserName: 0;
  private authorizer: IAuthorizer | null;
  private mailService: IMailService | null;
  private _loginCount: number = 0;

  constructor(
    authorizer: IAuthorizer | null,
    mailService: IMailService | null
  ) {
    this.authorizer = authorizer;
    this.mailService = mailService;
  }

  public loginCount(): number {
    return this._loginCount;
  }

  public performLogin(userName: string, password: string): void {
    if (!userName) {
      this.mailService?.sendSystemFailureMail(System.errorInvalidUserName);
      return;
    }

    if (!this.authorizer?.authorize(userName, password)) {
      this.mailService?.sendLoginFailureMail(userName);
      return;
    }

    this._loginCount++;
  }
}
