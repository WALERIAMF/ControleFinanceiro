import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { HttpClientModule} from "@angular/common/http"
import { CategoriasService } from "./Services/categorias.service";
import { TipoService } from "./Services/tipos.service";
import { ListagemCategoriasComponent } from "./components/Categoria/listagem-categorias/listagem-categorias.component";
import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from "@angular/core";




@NgModule({
  declarations: [
    AppComponent,
    ListagemCategoriasComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule
  ],
  providers: [
    TipoService,
    CategoriasService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
