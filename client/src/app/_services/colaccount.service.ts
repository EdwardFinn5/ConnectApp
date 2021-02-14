import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

import { ColUser } from '../_models/coluser';

@Injectable({
  providedIn: 'root',
})
export class ColAccountService {
  baseUrl = environment.apiUrl;
  private currentColUserSource = new ReplaySubject<ColUser>(1);
  currentUser$ = this.currentColUserSource.asObservable();
  colUserType: string;

  constructor(private http: HttpClient) {}

  login(model: any) {
    return this.http.post(this.baseUrl + 'colaccount/collogin', model).pipe(
      map((response: ColUser) => {
        const colUser = response;
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentColUserSource.next(colUser);
          this.colUserType = colUser.colUserType;
        }
      })
    );
  }

  colRegister(model: any) {
    return this.http
      .post(this.baseUrl + 'colaccount/registercollege', model).pipe(
        map((colUser: ColUser) => {
          if (colUser) {
            localStorage.setItem('colUser', JSON.stringify(colUser));
            this.currentColUserSource.next(colUser);
            this.colUserType = colUser.colUserType;
          }
        })
      )
  }

  hsRegister(model: any) {
    return this.http.post(this.baseUrl + 'colaccount/registerhs', model).pipe(
      map((colUser: ColUser) => {
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentColUserSource.next(colUser);
          this.colUserType = colUser.colUserType;
        }
      })
    )
  }

  setCurrentUser(colUser: ColUser) {
    this.currentColUserSource.next(colUser);
    this.colUserType = colUser.colUserType;
  }

  logout() {
    localStorage.removeItem('colUser');
    localStorage.removeItem('loginStatus');
    this.currentColUserSource.next(null);
  }
}
