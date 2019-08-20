import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProvedoresListComponent } from './provedores-list.component';

describe('ProvedoresListComponent', () => {
  let component: ProvedoresListComponent;
  let fixture: ComponentFixture<ProvedoresListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProvedoresListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProvedoresListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
