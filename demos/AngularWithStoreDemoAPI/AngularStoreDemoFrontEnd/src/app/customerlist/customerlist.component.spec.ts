import { HttpClientModule } from '@angular/common/http';
import { ɵCompiler_compileModuleAndAllComponentsAsync__POST_R3__ } from '@angular/core';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { CustomerService } from '../customer.service';

import { CustomerlistComponent } from './customerlist.component';
import { StubCustomerService } from './StubCustomerService';

describe('CustomerlistComponent', () => {
  let component: CustomerlistComponent;
  let fixture: ComponentFixture<CustomerlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientModule],
      declarations: [CustomerlistComponent],
      providers: [CustomerlistComponent, { provide: CustomerService, useClass: StubCustomerService }]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should return the number doubled', () => {
    let result = component.testexample(5);
    expect(result).toBe(10);
  });

  it('populates the customerlist with the returned array of customers', () => {
    // let mocklist = [{ fname: "mark", lname: "Moore" }, { fname: "Jeffrey", lname: "Moore" }, { fname: "Brian", lname: "Stockton" }];
    //let spy = spyOn(component, "observablelist").and.returnValue(of(mocklist));
    // use the stub of the service class to mock the array returned
    component.ngOnInit();
    expect(component.customerlist.length).toBe(3);
    expect(component.customerlist[1].fname).toContain('ffr');
    // expect(component.).toHaveBeenCalledTimes(1);
  });

  it('displays the correct list to the user', () => {
    //stub the list (DONE)
    let liarray = fixture.nativeElement.getElementsByTagName('h3');
    console.log();
    expect(liarray[0].innerText).toContain('mark Moore');
  });


});// end of test class.
