import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  model: any = {};
 
  constructor(
    public accountService: AccountService,
    public colAccountService: ColAccountService,
    private router: Router,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
  }

  // login() {
  //   this.accountService.login(this.model).subscribe(response => {
  //     this.router.navigateByUrl('/memberlist');
  //   })
  // }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }

  colLogout() {
    this.colAccountService.logout();
    this.router.navigateByUrl('/');
  }

}

  // onLoginBtn() {
  //   this.router.navigate(['/userlogin']);
  // }

