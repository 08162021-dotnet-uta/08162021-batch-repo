import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms-examples',
  templateUrl: './forms-examples.component.html',
  styleUrls: ['./forms-examples.component.css']
})
export class FormsExamplesComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  //register form - fname, lname, phone number, username, password 
  reactiveformexample = new FormGroup({
    fname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3), Validators.pattern('[a-zA-Z ]*')]),
    lname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3)]),
    email: new FormControl('', Validators.email),
    phonenumber: new FormControl('', [Validators.required]),
    username: new FormControl('', [Validators.required, Validators.pattern('^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$')]),
    password: new FormControl('', Validators.required)
  });

  fname2?: string;
  lname2?: string;
  email2?: string;
  phonenumber2?: string;
  username2?: string;
  password2?: string;

  submitReactiveForm() {
    console.log(`fname - ${this.reactiveformexample.get('fname')?.value},\n lname - ${this.reactiveformexample.get('lname')?.value},\n email-${this.reactiveformexample.get('email')?.value},\n phonenumber-${this.reactiveformexample.get('phonenumber')?.value},\n username-${this.reactiveformexample.get('username')?.value},\n password-${this.reactiveformexample.get('password')?.value}`);
  }

  get fname() { return this.reactiveformexample.get('fname'); }// use this function as shorthand to get the value of htis field in the .html

  submitTemplateForm() {
    console.log(`${this.fname2}, ${this.lname2}, ${this.email2}, ${this.phonenumber2}, ${this.username2}, ${this.password2}`);
  }

}
