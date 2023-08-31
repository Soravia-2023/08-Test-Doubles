import { IAuthorizer } from "@/IAuthorizer";

export default class authorizerDummy implements IAuthorizer {
  authorize(userName: string, password: string): boolean {
    return false;
  }
}
