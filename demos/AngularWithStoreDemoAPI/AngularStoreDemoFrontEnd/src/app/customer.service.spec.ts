import { HttpClientTestingModule } from '@angular/common/http/testing';//need this in the service to rid yourself of the no httpclient error failed test
import { TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { Customer } from './customer';

import { CustomerService } from './customer.service';
import { CustomerMock } from './mockCustomerList';

describe('CustomerService', () => {
  let service: CustomerService;
  let httpClientSpy: { get: jasmine.Spy };

  beforeEach(() => {
    // TestBed.configureTestingModule({
    //   imports: [HttpClientTestingModule],
    // });
    // service = TestBed.inject(CustomerService);

    httpClientSpy = jasmine.createSpyObj('HttpClient', ['get']);
    service = new CustomerService(httpClientSpy as any);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should fake the http call and return the mockcustomerlist', () => {
    let result: Customer[] = [];
    httpClientSpy.get.and.returnValue(of(CustomerMock));
    service.CustomerList().subscribe(x => result = x);
    expect(result.length).toBe(3);

  });


});// end of service class
