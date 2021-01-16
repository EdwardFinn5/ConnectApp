import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AccountService } from '../_services/account.service';
// import { AlertifyService } from 'src/app/services/alertify.service';
// import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;

  constructor(private accountService: AccountService,
              private router: Router) { }
  
  ngOnInit(): void {
  

  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedIn = true;
      this.router.navigateByUrl('/memberlist');
    }, error => {
      console.log(error);
    })
  }

  logout() {
    this.loggedIn = false;
  }
}