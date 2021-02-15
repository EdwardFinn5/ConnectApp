import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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
  @Output() cancelLogin = new EventEmitter();

  constructor(private accountService: AccountService,
              private router: Router,
              private toastr: ToastrService) { }
  
  ngOnInit(): void {
  

  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedIn = true;
      this.router.navigateByUrl('/memberlist');
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }

  logout() {
    this.loggedIn = false;
  }

  cancel() {
    console.log('cancelled');
    this.cancelLogin.emit(false);
  }
}