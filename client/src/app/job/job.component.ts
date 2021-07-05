import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-jobs',
  templateUrl: './job.component.html',
  styleUrls: ['./job.component.css'],
})
export class JobComponent implements OnInit {
  registerMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(
    public accountService: AccountService,
    private router: Router,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
    // this.getUsers();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }

  // getUsers() {
  //   this.http.get('https://localhost:5001/api/users')
  //     .subscribe(users => this.users = users);

  // }

  login() {
    this.accountService.login(this.model).subscribe((response) => {
      this.router.navigateByUrl('/memberlist');
    });
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }

  onLoginBtn() {
    this.router.navigate(['/userlogin']);
  }

  onRegisterBtn() {
    this.router.navigate(['/register']);
  }

  cancel() {
    console.log('cancelled');
    this.router.navigateByUrl('/');
  }
}
