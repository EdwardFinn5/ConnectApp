import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { AccountService } from '../_services/account.service';
import { User } from '../_models/user';
import { take } from 'rxjs/operators';
import { ColAccountService } from '../_services/colAccount.service';
import { ColUser } from '../_models/coluser';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private accountService: AccountService,
              private colAccountService: ColAccountService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let currentUser: User;
    let colCurrentUser: ColUser;

    this.accountService.currentUser$.pipe(take(1)).subscribe(user => currentUser = user);
    if (currentUser) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${currentUser.token}`
        }
      })
    }

    this.colAccountService.currentUser$.pipe(take(1)).subscribe(colUser => colCurrentUser = colUser);
    if (colCurrentUser) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${colCurrentUser.token}`
        }
      })
    }

    return next.handle(request);
  }
}
