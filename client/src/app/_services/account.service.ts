import { HttpClient } from '@angular/common/http';
import { stringify } from '@angular/compiler/src/util';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

import { User } from '../_models/user';
import { PresenceService } from './presence.service';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  baseUrl = environment.apiUrl;
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  appUserType: string;

  constructor(private http: HttpClient, private presence: PresenceService) {}

  login(model: any) {
    return this.http.post(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          this.setCurrentUser(user); //added this line when we moved the one below to setCurrentUser
          this.presence.createHubConnection(user);
          // localStorage.setItem('user', JSON.stringify(user));
          // this.currentUserSource.next(user);
          // this.appUserType = user.appUserType;
        }
      })
    );
  }

  register(model: any) {
    return this.http.post(this.baseUrl + 'account/registercolprep', model).pipe(
      map((user: User) => {
        if (user) {
          this.setCurrentUser(user); //added this line when we moved the one below to setCurrentUser
          this.presence.createHubConnection(user);
          // localStorage.setItem('user', JSON.stringify(user));
          // this.currentUserSource.next(user);
          // this.appUserType = user.appUserType;
        }
      })
    );
  }

  empRegister(model: any) {
    return this.http.post(this.baseUrl + 'account/registeremp', model).pipe(
      map((user: User) => {
        if (user) {
          this.setCurrentUser(user); //added this line when we moved the one below to setCurrentUser
          this.presence.createHubConnection(user);
          // localStorage.setItem('user', JSON.stringify(user));
          // this.currentUserSource.next(user);
          // this.appUserType = user.appUserType;
        }
      })
    );
  }

  setCurrentUser(user: User) {
    user.roles = [];
    const roles = this.getDecodedToken(user.token).role;
    Array.isArray(roles) ? (user.roles = roles) : user.roles.push(roles);
    localStorage.setItem('user', JSON.stringify(user)); //added this line here from above register methods
    this.currentUserSource.next(user);
    this.appUserType = user.appUserType;
  }

  logout() {
    localStorage.removeItem('user');
    localStorage.removeItem('loginStatus');
    this.currentUserSource.next(null);
    this.presence.stopHubConnection();
  }

  getDecodedToken(token) {
    return JSON.parse(atob(token.split('.')[1]));
  }
}
