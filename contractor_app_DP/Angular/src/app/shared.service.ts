import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIUrl="http://localhost:62407"


  constructor(private http:HttpClient) { }

  

getContList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Contractor');
}

addCont(val:any){
  return this.http.post(this.APIUrl+'/Contractor',val);
}
updateCont(val:any){
  return this.http.put(this.APIUrl+'/Contractor',val);
}
deleteCont(val:any){
  return this.http.delete(this.APIUrl+'/Contractor/'+val);
}

// getAddressList():Observable<any[]>{
//   return this.http.get<any>(this.APIUrl+'/Address');
// }
// addAddress(val:any){
// return this.http.post(this.APIUrl+'/Address',val);
// }
// updateAddress(val:any){
// return this.http.put(this.APIUrl+'/Address',val);
// }
// deleteAddress(val:any){
// return this.http.delete(this.APIUrl+'/Address/'+val);
// }
//get all dep names??
}
