import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ColAccountService } from '../_services/colAccount.service';

@Injectable({
  providedIn: 'root'
})
export class ColAuthGuard implements CanActivate {
  
  constructor(private colAccountService: ColAccountService,
              private toastr: ToastrService) { }

  canActivate(): Observable<boolean> {
    return this.colAccountService.currentUser$.pipe(
      map(colUser => {
        if (colUser) return true;
        this.toastr.error("You must be signed in to view this list!")
      })
    )
  }
}
