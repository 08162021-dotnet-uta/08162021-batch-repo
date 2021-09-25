import { Observable, of } from "rxjs";
import { Customer } from "../customer";
import { CustomerMock } from "../mockCustomerList";

export class StubCustomerService {
  CustomerList(): Observable<Customer[]> {
    // return this.http.get<Customer[]>(`${this.url}Customerlist`);
    return of(CustomerMock);
  }
}