import { Component, OnInit } from '@angular/core';
import { OrdenServicioService } from 'src/app/servicios/orden-servicio.service';
import {NgForm} from '@angular/forms';
import {ToastrService}  from 'ngx-toastr';
import { ListaProveedores } from 'src/app/models/listaProveedores';
import { ProveedoresService } from 'src/app/servicios/proveedores.service';

@Component({
  selector: 'app-orden-servicio',
  templateUrl: './orden-servicio.component.html',
  styleUrls: ['./orden-servicio.component.css']
})
export class OrdenServicioComponent implements OnInit {

  constructor(private service: OrdenServicioService,private servicioProv:ProveedoresService, private toastr:ToastrService ) { }


listaProveedores: ListaProveedores[];


turno : any = "Seleccionar";
turno_values: any = ["Mañana", "Tarde"];




  ngOnInit() {
    this.resetForm();
    this.servicioProv.refreshList();
  }



  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      NIdSo: 0,
      Turno: '',
      FechaEstimada: '',
      FechaRegistro: Date.now.toString(),
      Observacion: '',
      NIdProvNId:0

    }
  }


  onSubmit(form: NgForm) {
    if (this.service.formData.NIdSo == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postPaymentDetail().subscribe(
      res => {
  
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Orden de Servicios  Registrada');
        this.service.refreshList();
   
      },
      err => {
   
        console.log(err);
      }
    )
    
  }

  updateRecord(form: NgForm) {
    this.service.putPaymentDdetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info('Submitted successfully', 'Orden de Servicios Actualizada');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }



}
