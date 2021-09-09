import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Tipo } from 'models/Tipo';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TiposService {

  url: string = 'api/Tipo';

constructor(private http: HttpClient) { }

PagarTodos(): Observable<Tipo[]>{
  return this.http.get<Tipo[]>(this.url)
}

}
