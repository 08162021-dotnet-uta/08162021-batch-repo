import { Component, OnInit } from '@angular/core';
import { from, Observable, of, Subject } from 'rxjs';
import { Customer } from '../customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customerlist',
  templateUrl: './customerlist.component.html',
  styleUrls: ['./customerlist.component.css']
})
export class CustomerlistComponent implements OnInit {

  // inject services into the constructor. WHY???
  // constuctor creates the class.. then html is created, etc...
  constructor(private customerService: CustomerService) { }

  selectedCustomer?: Customer;
  customerlist: Customer[] = [];
  customerlist2: Customer[] = [];
  tempcustomerlist: Customer[] = [];
  subject = new Subject<Customer[]>();
  observablelist = this.customerService.CustomerList();
  // THEN, after services are set up, etc... you use the service to initialize values.
  ngOnInit(): void {
    this.observablelist
      .subscribe(
        x => {
          this.customerlist = x
          //this.customerlist2 = x
        },// runs if successful
        jimmy => console.log(`There was a ${jimmy} error`), // runs only if there was an error
        () => console.log(`There was something I wanted to say...`)// always runs.
      );
    // get the most current array
    // then assign it to the subject as assignment to customerlist.
    // this.observablelist.subscribe(x => this.tempcustomerlist = x);
    // this.tempcustomerlist.map(x => console.log(x.fname));
    // this.subject.subscribe({ next: (v) => this.customerlist = v });

    // this.subject.subscribe({
    //   next: (v) => {
    //     this.customerlist = v
    //   }
    // });
    // call next() to emit to all observers.
    //this.subject.next(tempcustomerlist);
  }

  customerdetails(id: number): void {
    this.selectedCustomer = this.customerlist.find(x => x.customerId === id);
  }

  // create functions to interact with the API throught he services (CustomerService).
  registernewcustomer(newCust: Customer): void {
    if (this.customerlist2.length === 0) {
      this.observablelist.subscribe(x => this.customerlist2 = x);
    }
    this.customerService.NewCustomer(newCust).subscribe(
      x => this.customerlist2.push(x),
      err => console.log(`something went wrong when trying to add the new customer.`)
    );
    // this.customerService.NewCustomer(c).subscribe((x) => this.observablelist.subscribe(x => this.customerlist2 = x));
    // this.subject.subscribe({ next: (newsub) => this.customerService.NewCustomer(newCust).subscribe(y => x = y)});
    // create an array
    //let tempcustomerlist: Customer[] = [];
    // get the most current array
    //this.observablelist.subscribe(x => tempcustomerlist = x);
    // then assign it to the subject as assignment to customerlist.
    // if (!this.customerlist2) {
    //   this.subject.subscribe({ next: (v) => this.customerlist2 = v });
    // }
    // call next() to emit to all observers.
    //this.subject.next(tempcustomerlist);
  }

  sortbynumbers(): void {
    this.customerlist.reverse();
  }


  sortalpha(): void {
    this.customerlist.sort((a, b) => {
      if (a.fname.toLowerCase() < b.fname.toLowerCase()) { return -1; }
      if (a.fname.toLowerCase() > b.fname.toLowerCase()) { return 1; }
      return 0;
    })
  }

  testexample(x: number): number {
    return x * 2;
  }


}
