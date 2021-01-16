import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ColAccountService } from '../_services/colAccount.service';

@Component({
  selector: 'app-hsregister',
  templateUrl: './hsregister.component.html',
  styleUrls: ['./hsregister.component.css']
})
export class HsRegisterComponent implements OnInit {
  @Output() cancelHsRegister = new EventEmitter();
  model: any = {};

  constructor(
    private colAccountService: ColAccountService,
    private toastr: ToastrService,
    private router: Router
  ) {}

  ngOnInit(): void {
  }

  hsRegister() {
    this.colAccountService.hsRegister(this.model).subscribe(
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
    this.cancelHsRegister.emit(false);
  }

}
