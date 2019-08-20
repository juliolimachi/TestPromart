import { Component, OnInit } from '@angular/core';
import { ProveedoresService } from 'src/app/servicios/proveedores.service';
import { ToastrService } from 'ngx-toastr';
import { Proveedor } from 'src/app/models/proveedor';

@Component({
  selector: 'app-provedores-list',
  templateUrl: './provedores-list.component.html',
  styleUrls: ['./provedores-list.component.css']
})
export class ProvedoresListComponent implements OnInit {

  constructor(private service:ProveedoresService ,private toastr:ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }


  populateForm(provedores:Proveedor){
  
    //this.servicePayment.formData=tarjetas;  Cuando editas actualiza en el table
    this.service.formDataProveedor =Object.assign({},provedores);
  }

  onDelete(PMId) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteProveedorDetail(PMId)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Proveedor Detail Eliminado');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }

}
