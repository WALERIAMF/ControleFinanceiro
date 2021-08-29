import { Component, OnInit } from '@angular/core';
import { CategoriasService } from 'src/app/Services/categorias.service';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-listagem-categorias',
  templateUrl: './listagem-categorias.component.html',
  styleUrls: ['./listagem-categorias.component.css']
})
export class ListagemCategoriasComponent implements OnInit 
{

  categoria = new MatTableDataSource<any>();
  displayedColumns: string[] | undefined;

  constructor(private categoriasService: CategoriasService) { }

    ngOnInit(): void {
      this.categoriasService.PegarTodos().subscribe(resultado =>
        { 
          this.categoria.data = resultado;
        });
    this.displayedColumns = this.ExibirColunas();
  }

    ExibirColunas(): string[]
    {
      return['nome', 'icone', 'tipo', 'acoes']
    } 
}
