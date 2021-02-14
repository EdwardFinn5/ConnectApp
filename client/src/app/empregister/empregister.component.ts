import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-empregister',
  templateUrl: './empregister.component.html',
  styleUrls: ['./empregister.component.css']
})
export class EmpRegisterComponent implements OnInit {
  @Output() cancelEmpRegister = new EventEmitter();
  model: any = {};

  constructor(
    private accountService: AccountService,
    private toastr: ToastrService,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  empRegister() {
    //  this.cancelRegister.emit(false);
      this.accountService.empRegister(this.model).subscribe(response => {
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
      console.log('cancelled in log')
      this.cancelEmpRegister.emit(false);
    }

}
