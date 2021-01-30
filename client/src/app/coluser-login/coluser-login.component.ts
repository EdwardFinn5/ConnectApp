import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-coluser-login',
  templateUrl: './coluser-login.component.html',
  styleUrls: ['./coluser-login.component.css']
})
export class ColUserLoginComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;

  constructor(private colAccountService: ColAccountService,
              private router: Router) { }
  
  ngOnInit(): void {
  }

  login() {
    this.colAccountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedIn = true;
      this.router.navigateByUrl('/colmemberlist');
    }, error => {
      console.log(error);
    })
  }

  logout() {
    this.loggedIn = false;
  }
}
