export interface IMailService {
  sendLoginFailureMail(userName: string): void;
  sendSystemFailureMail(errorType: number): void;
}
