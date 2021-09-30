import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddeditContreahentComponent } from './add-edit-cont.component';

describe('AddeditContreahentComponent', () => {
  let component: AddeditContreahentComponent;
  let fixture: ComponentFixture<AddeditContreahentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddeditContreahentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddeditContreahentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
