import { Component, OnInit } from '@angular/core';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-coluser-login',
  templateUrl: './coluser-login.component.html',
  styleUrls: ['./coluser-login.component.css']
})
export class ColUserLoginComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;

  constructor(private colAccountService: ColAccountService) { }
  
  ngOnInit(): void {
  }

  login() {
    this.colAccountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedIn = true;
    }, error => {
      console.log(error);
    })
  }

  logout() {
    this.loggedIn = false;
  }
}
