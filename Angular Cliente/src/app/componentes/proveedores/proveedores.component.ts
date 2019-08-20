import { Component, OnInit } from '@angular/core';
import { Proveedor } from 'src/app/models/proveedor';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { ProveedoresService } from 'src/app/servicios/proveedores.service';

@Component({
  selector: 'app-proveedores',
  templateUrl: './proveedores.component.html',
  styleUrls: ['./proveedores.component.css']
})
export class ProveedoresComponent implements OnInit {



  constructor(private service: ProveedoresService,
    private toastr: ToastrService) { }

  ngOnInit() {
  
    this.resetForm();
  }


  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formDataProveedor = {
      NId: 0,
      Ruc: '',
      RazonSocial: '',
      Direccion: '',
      Nombre: ''
    }
  }

  onSubmit(form: NgForm) {
    if (this.service.formDataProveedor.NId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postProveedorDetail().subscribe(
      res => {
      

        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Payment Detail Register');
        this.service.refreshList();


   
      },
      err => {
   
        console.log(err);
      }
    )
    

  }
  updateRecord(form: NgForm) {
    this.service.putProveedorDdetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info('Submitted successfully', 'Payment Detail Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }
}
