import { ListagemCategoriasComponent } from './components/Categoria/ListagemCategoria/ListagemCategoria.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path : 'categoria/listagemcategoria', component: ListagemCategoriasComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
