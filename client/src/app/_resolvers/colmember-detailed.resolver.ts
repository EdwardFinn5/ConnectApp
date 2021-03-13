import { Injectable } from '@angular/core';
import {
  Router,
  Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot,
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { ColMember } from '../_models/colMember';
import { MembersService } from '../_services/members.service';

@Injectable({
  providedIn: 'root',
})
export class ColMemberDetailedResolver implements Resolve<ColMember> {
  constructor(private memberService: MembersService) {}

  resolve(route: ActivatedRouteSnapshot): Observable<ColMember> {
    return this.memberService.getMember(route.paramMap.get('colusername'));
  }
}
