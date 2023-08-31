import { IAuthorizer } from "@/IAuthorizer";

export default class acceptingAuthorizerStub implements IAuthorizer {
  authorize(userName: string, password: string): boolean {
    return true;
  }
}
