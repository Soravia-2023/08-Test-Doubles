import { IAuthorizer } from "@/IAuthorizer";

export default class authorizerFake implements IAuthorizer {
  authorize(userName: string, password: string): boolean {
    return userName === "jimmy" ? true : false;
  }
}
