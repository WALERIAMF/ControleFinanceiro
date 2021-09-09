import { Component, OnInit, Output } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { CategoriasService } from 'services/categoria.service';


@Component({
  selector: 'app-listagem-categorias',
  templateUrl: './ListagemCategoria.component.html',
  styleUrls: ['./ListagemCategoria.component.css']
})
export class ListagemCategoriasComponent implements OnInit
{
	@Output()  categoria = new MatTableDataSource<any>();
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
