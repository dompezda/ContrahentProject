import { Component, OnInit, Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-cont',
  templateUrl: './add-edit-cont.component.html',
  styleUrls: ['./add-edit-cont.component.css']
})
export class AddeditContreahentComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() cont:any;
  ContractorId!:String;
  FirstName!:string;
  Surname!:string;
  REGON!:string;
  NIP!:string;
  ContactNumber!:string;
  City!:string;
  Country!:string;
  Street!:string;
  PostalCode!:string;
  HomeNumber!:string;


  ngOnInit(): void {
    this.ContractorId=this.cont.ContractorId;
    this.FirstName=this.cont.FirstName;
    this.Surname=this.cont.Surname;
    this.REGON=this.cont.REGON;
    this.NIP=this.cont.NIP;
    this.ContactNumber=this.cont.ContactNumber;
    this.City=this.cont.City;
    this.Country=this.cont.Country;
    this.Street=this.cont.Street;
    this.PostalCode=this.cont.PostalCode;
    this.HomeNumber=this.cont.HomeNumber;
  }

  AddContrahent(){

    var value ={
      ContractorId:this.ContractorId,
      FirstName:this.FirstName,
      Surname:this.Surname,
      NIP:this.NIP,
      REGON:this.REGON,
      Country:this.Country,
      City:this.City,
      Street:this.Street,
      HomeNumber:this.HomeNumber,
      PostalCode:this.PostalCode,
      ContactNumber:this.ContactNumber
    };
    this.service.AddContrahent(value).subscribe(res=>{
      alert(res.toString());
    });
  }
  
  editContreahent(){
    var value ={
      ContractorId:this.ContractorId,
      FirstName:this.FirstName,
      Surname:this.Surname,
      NIP:this.NIP,
      REGON:this.REGON,
      Country:this.Country,
      City:this.City,
      Street:this.Street,
      HomeNumber:this.HomeNumber,
      PostalCode:this.PostalCode,
      ContactNumber:this.ContactNumber
    };
    this.service.UpdateContrahent(value).subscribe(res=>{
      alert(res.toString());
    });
  }

}
