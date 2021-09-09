import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Injectable } from '@angular/core/';
import { Categoria } from 'models/Categoria';

import { Observable } from 'rxjs';

const httpOptions =
{
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

@Component({
  selector: 'app-typical',
  template: '<div>A typical component for {{data.name}}</div>'
})

export class CategoriasService
{

  url = 'api/Categoria';
  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<Categoria[]>
  {
    return this.http.get<Categoria[]>(this.url);
  }

  PegarCategoriaPeloId(IdInterno: string): Observable<Categoria>
  {
    const apiUrl = `${this.url}/${IdInterno}`;
    return this.http.get<Categoria>(apiUrl);
  }

  NovaCategoria(categoria: Categoria): Observable<any>
  {
    return this.http.post<Categoria>(this.url, categoria, httpOptions);
  }

  AtualizarCategoria(IdInterno: string, categoria: Categoria): Observable<any>
  {
    const apiUrl = `${this.url}/${IdInterno}`;
    return this.http.put<Categoria>(apiUrl, categoria, httpOptions);
  }

  ExcluirCategoria(IdInterno: number): Observable<any>
  {
    const apiUrl = `${this.url}/${IdInterno}`;
    return this.http.delete<string>(apiUrl, httpOptions);
  }

}
