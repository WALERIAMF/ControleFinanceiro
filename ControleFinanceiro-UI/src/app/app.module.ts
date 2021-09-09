import { ComponentFixture } from '@angular/core/testing';
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { MatTableModule } from "@angular/material/table";
import { BrowserModule } from "@angular/platform-browser";
import { CategoriaService } from "models/categoria.service";
import { TiposService } from "services/tipos.service";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { ListagemCategoriasComponent } from "./components/Categoria/ListagemCategoria/ListagemCategoria.component";
import { MatIconModule } from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';





@NgModule({
  declarations: [
    AppComponent, ListagemCategoriasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule,
    HttpClientModule,

  ],
  providers: [
    TiposService,
    CategoriaService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
