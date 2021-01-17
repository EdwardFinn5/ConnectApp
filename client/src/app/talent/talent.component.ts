import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-talent',
  templateUrl: './talent.component.html',
  styleUrls: ['./talent.component.css']
})
export class TalentComponent implements OnInit {
  empRegisterMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(public accountService: AccountService,
              private router: Router,
              private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  registerToggle() {
    this.empRegisterMode = !this.empRegisterMode;
  }

  cancelEmpRegisterMode(event: boolean) {
    this.empRegisterMode = event;
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/memberlist');
    })
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }

  onLoginBtn() {
    this.router.navigate(['/userlogin']);
  }

  onRegisterBtn() {
    this.router.navigate(['/empregister']);
  }
}
