import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css']
})
export class CollegeComponent implements OnInit {
  hsRegisterMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(public colAccountService: ColAccountService,
              private router: Router,
              private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  registerToggle() {
    this.hsRegisterMode = !this.hsRegisterMode;
  }

  cancelHsRegisterMode(event: boolean) {
    this.hsRegisterMode = event;
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
    this.router.navigate(['/hsregister']);
  }
}


