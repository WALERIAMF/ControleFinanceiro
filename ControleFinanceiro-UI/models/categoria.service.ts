import { Categoria } from './Categoria';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new  HttpHeaders ({
    "Content-Type" : 'aplication/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {
  url = 'api/Categoria';

constructor(private http: HttpClient) { }

  PagarTodos(): Observable<Categoria[]>{
  return this.http.get<Categoria[]>(this.url);
  }
  PegarCategoriaPeloId(categoriaId: string) : Observable<Categoria>{
  const apiUrl = `${this.url}/${categoriaId}`;
  return this.http.get<Categoria>(apiUrl);
  }

  NovaCategoria(categoria: Categoria) : Observable<any>{
  return this.http.post<Categoria>(this.url, categoria, httpOptions);
  }

  AtualizarCategoria(categoriaId: string, categoria: Categoria): Observable<any>{
    const apiUrl = `${this.url}/${categoriaId}`;
    return this.http.put<Categoria>(apiUrl, categoria, httpOptions);
  }

  ExcluiCategoria(categoriaId: string) : Observable<any>{
    const apiUrl = '${this.url}/${categoriaId}';
    return this.http.delete<number>(apiUrl, httpOptions);
  }
}
