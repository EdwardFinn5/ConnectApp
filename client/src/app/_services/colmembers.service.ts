import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { ColMember } from '../_models/colMember';

// const httpOptions = {
//   headers: new HttpHeaders({
//     Authorization: 'Bearer ' + JSON.parse(localStorage.getItem('colUser'))?.token 
//   })
// }

@Injectable({
  providedIn: 'root'
})
export class ColMembersService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getColMembers() {
    return this.http.get<ColMember[]>(this.baseUrl + 'colusers');
  }

  getColMember(colusername: string) {
    return this.http.get<ColMember>(this.baseUrl + 'colusers/' + colusername);
  }

}
