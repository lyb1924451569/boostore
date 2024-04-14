import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { BookStoreComponent } from './components/book-store.component';
import { BookStoreService } from '@acme/book-store';
import { of } from 'rxjs';

describe('BookStoreComponent', () => {
  let component: BookStoreComponent;
  let fixture: ComponentFixture<BookStoreComponent>;
  const mockBookStoreService = jasmine.createSpyObj('BookStoreService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [BookStoreComponent],
      providers: [
        {
          provide: BookStoreService,
          useValue: mockBookStoreService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookStoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
