import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ColMember } from 'src/app/_models/colMember';
import { ColMembersService } from 'src/app/_services/colmembers.service';

@Component({
  selector: 'app-colmember-detail',
  templateUrl: './colmember-detail.component.html',
  styleUrls: ['./colmember-detail.component.css']
})
export class ColMemberDetailComponent implements OnInit {
  colMember: ColMember;

  constructor(private colMemberService: ColMembersService,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadColMember();
  }


 loadColMember() {
    this.colMemberService.getColMember(this.route.snapshot.paramMap.get('colusername')).subscribe(colMember => {
      this.colMember = colMember;
    });
  }
}
