import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-hsstudent',
  templateUrl: './hsstudent.component.html',
  styleUrls: ['./hsstudent.component.css']
})
export class HsStudentComponent implements OnInit {
  registerMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(public colAccountService: ColAccountService,
              private router: Router) { }

  ngOnInit(): void {
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }

  login() {
    this.colAccountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/memberlist');
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

