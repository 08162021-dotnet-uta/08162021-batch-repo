import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-login-customer',
  templateUrl: './login-customer.component.html',
  styleUrls: ['./login-customer.component.css']
})
export class LoginCustomerComponent implements OnInit {
  @Input() logintrue: boolean = false;
  fname: string = 'First Name';
  lname: string = 'Last Name';

  constructor() { }


  ngOnInit(): void {
    // this.logintrue = true;
  }

}
