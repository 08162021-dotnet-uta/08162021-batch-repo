import { Component } from '@angular/core';
import { Customer } from './customer';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Marks really cool Angular demo';
  something?: string;// variables need to be initialized so a ? is placed to quiet that error
  logintrue: boolean = false;
  registertrue: boolean = false;
  titleclicked(value: string) {
    console.log(`${value}`)
  }

  registercustomer() {
    this.registertrue = !this.registertrue;
    this.logintrue = false;
  }

  registernewcustomer(cust: Customer) {
    // do something with the customer.
    // such as use the sevice (injected into the constructor) to add the 
    // custome to the Db through the API.
    console.log(`The new customer is ${cust.fname} ${cust.lname}`)
  }

  logincustomer() {
    this.logintrue = !this.logintrue;
    this.registertrue = false;
  }
}
