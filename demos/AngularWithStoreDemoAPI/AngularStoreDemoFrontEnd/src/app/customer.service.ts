import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from './customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }
  private url1 = 'http://localhost:44330/Customer/'
  private url2 = 'http://localhost:5001/Customer/' // had to change these from 'https' to 'http' bc the container isn't set up to use httos

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  // create functions to make http requests and other various and sundry actions.
  CustomerList(): Observable<Customer[]> {
    // return this.http.get<Customer[]>(`${this.url}Customerlist`);
    return this.http.get<Customer[]>(`${this.url2}customerlist`);
  }

  NewCustomer(c: Customer): Observable<Customer> {
    // return this.http.post<Customer>(`${this.url}register`, c, this.httpOptions);
    return this.http.post<Customer>(`${this.url2}register`, c, this.httpOptions);

  }
}
