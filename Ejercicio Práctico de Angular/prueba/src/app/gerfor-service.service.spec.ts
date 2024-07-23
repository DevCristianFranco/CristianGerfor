import { TestBed } from '@angular/core/testing';

import { GerforServiceService } from './gerfor-service.service';

describe('GerforServiceService', () => {
  let service: GerforServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GerforServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
