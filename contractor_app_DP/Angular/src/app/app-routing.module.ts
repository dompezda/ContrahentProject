import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {AddressComponent} from './address/address.component';
import {ContractorComponent} from './contractor/contractor.component';

const routes: Routes = [
{path:'address',component:AddressComponent},
{path:'contractor',component:ContractorComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
