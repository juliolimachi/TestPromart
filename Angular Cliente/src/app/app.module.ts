import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { OrdenServiciosComponent } from './componentes/orden-servicios/orden-servicios.component';
import { OrdenServicioComponent } from './componentes/orden-servicios/orden-servicio/orden-servicio.component';
import { OrdenServicioListComponent } from './componentes/orden-servicios/orden-servicio-list/orden-servicio-list.component';
import { ProveedoresComponent } from './componentes/proveedores/proveedores.component';
import { ServiciosComponent } from './componentes/servicios/servicios.component';
import { ProductosComponent } from './componentes/productos/productos.component';
import { ProveedoresService } from './servicios/proveedores.service';
import { ServiciosService } from './servicios/servicios.service';
import { OrdenServicioService } from './servicios/orden-servicio.service';
import { ProductosService } from './servicios/productos.service';

import { HttpClientModule}  from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProvedoresListComponent } from './componentes/proveedores/provedores-list/provedores-list.component';



@NgModule({
  declarations: [
    AppComponent,
    OrdenServiciosComponent,
    OrdenServicioComponent,
    OrdenServicioListComponent,
    ProveedoresComponent,
    ServiciosComponent,
    ProductosComponent,
    ProvedoresListComponent

  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [
    ProveedoresService,
    ServiciosService,
    OrdenServicioService,
    ProductosService

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
