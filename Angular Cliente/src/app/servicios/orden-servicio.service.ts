import { Injectable } from '@angular/core';

import { OrdenServicio } from '../models/orden-servicio';
import {HttpClient}  from '@angular/common/http';
import { ProveedoresService } from './proveedores.service';
import { Proveedor } from '../models/proveedor';
@Injectable({
  providedIn: 'root'
})
export class OrdenServicioService {

  formData : OrdenServicio;
  readonly rootUrl='https://localhost:44309/api';
  list:OrdenServicio[];
  listaProveedores: Proveedor[];
  constructor(private http: HttpClient,private service:ProveedoresService) { }
  
  
getProveedores(){
  return this.http.get(this.rootUrl+'/Proveedors');
}

postPaymentDetail(){
return this.http.post(this.rootUrl+'/OrdenServicios',this.formData);
}


putPaymentDdetail(){
  return this.http.put(this.rootUrl+'/OrdenServicios'+this.formData.NIdSo,this.formData);
}



deletePaymentDetail( id){
  debugger;
 return this.http.delete( this.rootUrl+'/OrdenServicios'+id);
}


refreshList(){
  this.http.get(this.rootUrl + '/Proveedors')
  .toPromise()
  .then(res => this.listaProveedores = res as Proveedor[]);
  debugger;
}

}
