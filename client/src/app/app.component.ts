import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'ICF Connect';
  // Users: any; // taking this out for now
  colUsers: any;
  users: any;

  // constructor(private accountService: AccountService) {}  //taking out for now

  constructor(private http: HttpClient) {}

  ngOnInit() {
    // this.setCurrentUser();  // taking this out for now as I go through 2nd time
   this.getColUsers();
   this.getUsers();
  }
  getUsers() {
    this.http.get('https://localhost:5001/api/users').subscribe( response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }

  getColUsers() {
    this.http.get('https://localhost:5001/api/colUsers').subscribe( response => {
      this.colUsers = response;
    }, error => {
      console.log(error);
    })
  }

  setCurrentUser() {
    const user: User = JSON.parse(localStorage.getItem('user'));
    // this.accountService.setCurrentUser(user);
  }

}




