import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginCustomerComponent } from './login-customer/login-customer.component';
import { RegisterCustomerComponent } from './register-customer/register-customer.component';
import { AppRoutingModule } from './app-routing.module';
import { FormsExamplesComponent } from './forms-examples/forms-examples.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginCustomerComponent,
    RegisterCustomerComponent,
    FormsExamplesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
