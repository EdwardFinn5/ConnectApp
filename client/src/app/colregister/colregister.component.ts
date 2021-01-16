import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-colregister',
  templateUrl: './colregister.component.html',
  styleUrls: ['./colregister.component.css']
})
export class ColRegisterComponent implements OnInit {
  @Output() cancelColRegister = new EventEmitter();
  model: any = {};

  constructor(
    private colAccountService: ColAccountService,
    private toastr: ToastrService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  colRegister() {
    this.colAccountService.colRegister(this.model).subscribe(
      (response) => {
        console.log(response);
        this.cancel();
        this.router.navigateByUrl('/memberlist');
      },
      (error) => {
        console.log(error);
        this.toastr.error(error.error);
      }
    );
  }

  cancel() {
    console.log('cancelled')
    this.cancelColRegister.emit(false);
  }
}
