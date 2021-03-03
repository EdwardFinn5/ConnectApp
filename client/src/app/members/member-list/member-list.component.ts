import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/_models/member';
import { Pagination } from 'src/app/_models/pagination';
import { User } from 'src/app/_models/user';
import { UserParams } from 'src/app/_models/UserParams';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css'],
})
export class MemberListComponent implements OnInit {
  members: Member[];
  pagination: Pagination;
  userParams: UserParams;
  user: User;
  major = '';
  position = '';
  hometown = '';
  searchMajors = '';
  searchHometowns = '';
  searchPositions = '';
  appUserType = [
    { value: 'ColStudent', display: 'Talent' },
    { value: 'EmpHr', display: 'Jobs' },
  ];
  majorList = [
    { value: 'Accounting', display: 'Accounting' },
    { value: 'IT', display: 'IT' },
  ];

  constructor(private membersService: MembersService) {
    this.userParams = this.membersService.getUserparams();
  }

  ngOnInit(): void {
    this.loadMembers();
  }

  loadMembers() {
    this.membersService.setUserParams(this.userParams);
    this.membersService.getMembers(this.userParams).subscribe((response) => {
      this.members = response.result;
      this.pagination = response.pagination;
    });
  }

  resetFilters() {
    this.userParams = this.membersService.resetUserParams();
    this.loadMembers();
  }

  pageChanged(event: any) {
    this.userParams.pageNumber = event.page;
    this.membersService.setUserParams(this.userParams);
    this.loadMembers();
  }

  onMajorFilter() {
    this.searchMajors = this.major;
  }

  onHometownFilter() {
    this.searchHometowns = this.hometown;
  }

  onPositionFilter() {
    this.searchPositions = this.position;
  }

  onMajorFilterClear() {
    this.searchMajors = '';
    this.major = '';
  }

  onHometownFilterClear() {
    this.searchHometowns = '';
    this.hometown = '';
  }

  onPositionFilterClear() {
    this.searchPositions = '';
    this.position = '';
  }
}
