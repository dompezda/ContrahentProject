import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
@Component({
  selector: 'app-show-address',
  templateUrl: './show-address.component.html',
  styleUrls: ['./show-address.component.css']
})
export class ShowAddressComponent implements OnInit {

  constructor(private service:SharedService) { }

  ContractorList:any=[];
  ModalTitle:string="";
  ActiveAddEditContComp:boolean=false;
  cont:any;


  ngOnInit(): void {
    this.refreshContList();
  }

addClick(){
  this.cont={
    ContractorId:0,
    FirstName:"",
    Surname:"",
    REGON:"",
    NIP:"",
    ContactNumber:"",
    City:"",
    Country:"",
    Street:"",
    PostalCode:"",
    HomeNumber:"",
  }
  this.ModalTitle="Dodaj nowego klienta";
  this.ActiveAddEditContComp=true;
}



editClick(item:any){
  this.cont=item;
  this.ModalTitle="Edycja istniejącego klienta";
  this.ActiveAddEditContComp=true;
}

closeClick(){
this.ActiveAddEditContComp=false;
this.refreshContList();
}

deleteClick(item:any){
  if(confirm("Czy na pewno chcesz usnąć obiekt z identyfikatorem "+item)){
    this.service.deleteCont(item).subscribe(data=>{
      alert(data.toString());
      this.refreshContList();
    })
  }

}

  refreshContList(){
    this.service.getContList().subscribe(data=>{
      this.ContractorList=data;
    })
  }
}
