import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { ColUser } from './_models/colUser';
import { AccountService } from './_services/account.service';
import { ColAccountService } from './_services/colAccount.service';
import { PresenceService } from './_services/presence.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'ICF Connect';
  // Users: any; // taking this out for now
  colUsers: any;
  users: any;
  appUserType: string;
  colUserType: string;

  // constructor(private accountService: AccountService) {}  //taking out for now

  constructor(
    private accountService: AccountService,
    private colAccountService: ColAccountService,
    private presence: PresenceService
  ) {}

  ngOnInit() {
    // this.setCurrentUser();  // taking this out for now as I go through 2nd time
    //  this.getColUsers();
    //  this.getUsers();
    this.setCurrentUser();
  }
  // getUsers() {
  //   this.http.get('https://localhost:5001/api/users').subscribe( response => {
  //     this.users = response;
  //   }, error => {
  //     console.log(error);
  //   })
  // }

  // getColUsers() {
  //   this.http.get('https://localhost:5001/api/colUsers').subscribe( response => {
  //     this.colUsers = response;
  //   }, error => {
  //     console.log(error);
  //   })
  // }

  setCurrentUser() {
    const user: User = JSON.parse(localStorage.getItem('user'));
    if (user) {
      this.accountService.setCurrentUser(user);
      this.appUserType = user.appUserType;
      this.presence.createHubConnection(user);
    }
    const colUser: ColUser = JSON.parse(localStorage.getItem('colUser'));
    if (colUser) {
      this.colAccountService.setCurrentUser(colUser);
      this.colUserType = colUser.colUserType;
    }
  }

  //   const user: User = JSON.parse(localStorage.getItem('user'));
  //   this.accountService.setCurrentUser(user);
  //   this.appUserType = user.appUserType;
  //   const colUser: ColUser = JSON.parse(localStorage.getItem('colUser'));
  //   this.colAccountService.setCurrentUser(colUser);
  //   this.colUserType = colUser.colUserType;
  // }
}
