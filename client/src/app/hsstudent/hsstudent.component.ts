import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-hsstudent',
  templateUrl: './hsstudent.component.html',
  styleUrls: ['./hsstudent.component.css']
})
export class HsStudentComponent implements OnInit {
  colRegisterMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(public colAccountService: ColAccountService,
              private router: Router,
              private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  registerToggle() {
    this.colRegisterMode = !this.colRegisterMode;
  }

  cancelColRegisterMode(event: boolean) {
    this.colRegisterMode = event;
  }

  login() {
    this.colAccountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/colmemberlist');
    })
  }

  logout() {
    this.colAccountService.logout();
    this.router.navigateByUrl('/');
  }

  onLoginBtn() {
    this.router.navigate(['/coluserlogin']);
  }

  onRegisterBtn() {
    this.router.navigate(['/colregister']);
  }
}

