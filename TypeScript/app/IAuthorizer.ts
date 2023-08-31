export interface IAuthorizer {
  authorize(userName: string, password: string): boolean;
}
