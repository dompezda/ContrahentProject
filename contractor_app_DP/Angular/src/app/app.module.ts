import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContractorComponent } from './contractor/contractor.component';
import { ShowContComponent } from './contractor/show-cont/show-cont.component';
import { AddeditContreahentComponent } from './contractor/add-edit-cont/add-edit-cont.component';
import { AddressComponent } from './address/address.component';
import { ShowAddressComponent } from './address/show-address/show-address.component';
import { AddEditAddressComponent } from './address/add-edit-address/add-edit-address.component';
import {SharedService} from './shared.service';

import {HttpClientModule} from '@angular/common/http';
import {FormsModule,ReactiveFormsModule} from '@angular/forms'

@NgModule({
  declarations: [
    AppComponent,
    ContractorComponent,
    ShowContComponent,
    AddeditContreahentComponent,
    AddressComponent,
    ShowAddressComponent,
    AddEditAddressComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
