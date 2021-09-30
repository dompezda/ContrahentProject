import { Component, OnInit } from '@angular/core';

import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-cont',
  templateUrl: './show-cont.component.html',
  styleUrls: ['./show-cont.component.css']
})
export class ShowContComponent implements OnInit {

  constructor(private service:SharedService) { }

  ContractorList:any=[];
  ModalTitle:string="";
  ActiveAddeditContreahentComp:boolean=false;
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
  this.ActiveAddeditContreahentComp=true;
}



editClick(item:any){
  this.cont=item;
  this.ModalTitle="Edycja istniejącego klienta";
  this.ActiveAddeditContreahentComp=true;
}

closeClick(){
this.ActiveAddeditContreahentComp=false;
this.refreshContList();
}

deleteClick(item:any){
  if(confirm("Czy na pewno chcesz usnąć obiekt z identyfikatorem "+item)){
    this.service.DeleteContrahent(item).subscribe(data=>{
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
