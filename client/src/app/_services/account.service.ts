import { HttpClient } from '@angular/common/http';
import { stringify } from '@angular/compiler/src/util';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.apiUrl;
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  appUserType: string;

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
          this.appUserType = user.appUserType;
        }
      })
    )
  }

  register(model: any) {
    return this.http.post(this.baseUrl + 'account/registercolprep', model).pipe(
      map((user: User) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
          this.appUserType = user.appUserType;
        }
      })
    )
  }

  empRegister(model: any) {
    return this.http.post(this.baseUrl + 'account/registeremp', model).pipe(
      map((user: User) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
          this.appUserType = user.appUserType;
        }
        return user;
      })
    )
  }

  setCurrentUser(user: User) {
  this.currentUserSource.next(user);
  this.appUserType = user.appUserType;
  }

  logout() {
    localStorage.removeItem('user');
    localStorage.removeItem('loginStatus');
    this.currentUserSource.next(null);
  }
}
