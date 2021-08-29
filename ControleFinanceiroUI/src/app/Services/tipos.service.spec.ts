import { TestBed } from '@angular/core/testing';

import {TipoService} from '../Services/tipos.service'

describe('TiposService', () => {
  let service: TipoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TipoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
