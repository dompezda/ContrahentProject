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

AddContrahent(val:any){
  return this.http.post(this.APIUrl+'/Contractor',val);
}
UpdateContrahent(val:any){
  return this.http.put(this.APIUrl+'/Contractor',val);
}
DeleteContrahent(val:any){
  return this.http.delete(this.APIUrl+'/Contractor/'+val);
}

}
