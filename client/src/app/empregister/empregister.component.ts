import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  ValidatorFn,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-empregister',
  templateUrl: './empregister.component.html',
  styleUrls: ['./empregister.component.css'],
})
export class EmpRegisterComponent implements OnInit {
  @Output() cancelEmpRegister = new EventEmitter();
  registerForm: FormGroup;
  validationErrors: string[] = [];

  constructor(
    private accountService: AccountService,
    private toastr: ToastrService,
    private router: Router,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm() {
    this.registerForm = this.fb.group({
      username: ['', Validators.required],
      firstName: ['', Validators.required],
      position: ['', Validators.required],
      positionType: ['Fulltime', Validators.required],
      startDate: ['', Validators.required],
      positionLocation: ['', Validators.required],
      company: ['', Validators.required],
      password: [
        '',
        [Validators.required, Validators.minLength(4), Validators.maxLength(8)],
      ],
      confirmPassword: [
        '',
        [Validators.required, this.matchValues('password')],
      ],
    });
    this.registerForm.controls.password.valueChanges.subscribe(() => {
      this.registerForm.controls.confirmPassword.updateValueAndValidity();
    });
  }

  matchValues(matchTo: string): ValidatorFn {
    return (control: AbstractControl) => {
      return control?.value === control?.parent?.controls[matchTo].value
        ? null
        : { isMatching: true };
    };
  }

  empRegister() {
    //  this.cancelRegister.emit(false);
    this.accountService.empRegister(this.registerForm.value).subscribe(
      (response) => {
        console.log(response);
        this.cancel();
        this.router.navigateByUrl('/memberlist');
      },
      (error) => {
        this.validationErrors = error;
      }
    );
  }

  cancel() {
    console.log('cancelled in log');
    this.cancelEmpRegister.emit(false);
    this.router.navigateByUrl('/');
  }
}
