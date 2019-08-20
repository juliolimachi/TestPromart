import { Injectable } from '@angular/core';
import { Proveedor } from '../models/proveedor';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProveedoresService {



  formDataProveedor : Proveedor;
  readonly rootUrl='https://localhost:44309/api';
  list:Proveedor[];
  constructor(private http: HttpClient) { }
  
  postProveedorDetail(){
return this.http.post(this.rootUrl+'/Proveedors',this.formDataProveedor);
}


putProveedorDdetail(){
  return this.http.put(this.rootUrl+'/Proveedors/'+this.formDataProveedor.NId,this.formDataProveedor);
}



deleteProveedorDetail( id){
  debugger;
 return this.http.delete( this.rootUrl+'/Proveedors/'+id);
}


refreshList(){
  this.http.get(this.rootUrl + '/Proveedors')
  .toPromise()
  .then(res => this.list = res as Proveedor[]);
  debugger;
}



}
