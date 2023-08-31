import { IAuthorizer } from "@/IAuthorizer";

export default class rejectingAuthorizerStub implements IAuthorizer {
  authorize(userName: string, password: string): boolean {
    return false;
  }
}
