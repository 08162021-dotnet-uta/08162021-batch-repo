import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormsExamplesComponent } from './forms-examples.component';

describe('FormsExamplesComponent', () => {
  let component: FormsExamplesComponent;
  let fixture: ComponentFixture<FormsExamplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormsExamplesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormsExamplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
