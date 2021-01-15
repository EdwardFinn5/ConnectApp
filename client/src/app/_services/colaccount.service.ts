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
  private currentUserSource = new ReplaySubject<ColUser>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) {}

  login(model: any) {
    return this.http.post(this.baseUrl + 'colaccount/collogin', model);
  }

  register(model: any) {
    return this.http.post(this.baseUrl + 'colaccount/registerhs', model).pipe(
      map((colUser: ColUser) => {
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentUserSource.next(colUser);
        }
      })
    );
  }

  setCurrentUser(colUser: ColUser) {
    this.currentUserSource.next(colUser);
  }

  logout() {
    localStorage.removeItem('colUser');
    this.currentUserSource.next(null);
  }
}
