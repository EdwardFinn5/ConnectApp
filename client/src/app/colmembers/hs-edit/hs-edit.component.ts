import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { ColMember } from 'src/app/_models/colMember';
import { ColUser } from 'src/app/_models/coluser';
import { ColAccountService } from 'src/app/_services/colAccount.service';
import { ColMembersService } from 'src/app/_services/colmembers.service';

@Component({
  selector: 'app-hs-edit',
  templateUrl: './hs-edit.component.html',
  styleUrls: ['./hs-edit.component.css']
})
export class HsEditComponent implements OnInit {
  @ViewChild('editForm') editForm: NgForm;
  colMember: ColMember;
  colUser: ColUser;
  @HostListener('window:beforeunload', ['$event']) unloadNotification($event: any) {
    if (this.editForm.dirty) {
      $event.returnValue = true;
    }
  }

  constructor(private colAccountService: ColAccountService,
              private colMemberService: ColMembersService,
              private toastr: ToastrService) {
      this.colAccountService.currentUser$.pipe(take(1))
        .subscribe(colUser => this.colUser = colUser);
     }

  ngOnInit(): void {
    this.loadColMember();
  }

  loadColMember() {
    this.colMemberService.getColMember(this.colUser.colUserName)
      .subscribe(colMember => {
        this.colMember = colMember;
      })
  }

  updateColMember() {
    console.log(this.colMember);
    this.toastr.success('Profile updated successfully');
    this.editForm.reset(this.colMember);
  }
}
